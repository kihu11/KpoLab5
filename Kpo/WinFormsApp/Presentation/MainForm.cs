using System;
using System.Linq;
using System.Windows.Forms;
using Kpo.Services;
using Kpo.Business.Entities;
using Kpo.Business.Enums;

namespace Kpo.WinFormsApp
{
    public partial class MainForm : Form
    {
        private readonly ServiceFacade _facade;
        private DailyRation _ration;
        private User _currentUser;

        public MainForm(ServiceFacade facade)
        {
            InitializeComponent();
            _facade = facade;

            // Создаём текущего пользователя и рацион
            _currentUser = new User
            {
                Name = "John Doe",
                Age = 30,
                Weight = 70,
                Height = 175,
                Activity = DailyActivity.Normal
            };

            _ration = _facade.MealService.CreateDailyRation(_currentUser);

            LoadCategories();
        }

        private void LoadCategories()
        {
            listBoxCategories.Items.Clear();
            var categories = _facade.CatalogService.GetAllCategories();
            foreach (var cat in categories)
            {
                listBoxCategories.Items.Add(cat.Name);
            }

            listBoxCategories.SelectedIndexChanged += (s, e) =>
            {
                if (listBoxCategories.SelectedItem != null)
                    LoadProducts(listBoxCategories.SelectedItem.ToString());
            };
        }

        private void LoadProducts(string categoryName)
        {
            listBoxProducts.Items.Clear();
            var category = _facade.CatalogService.GetAllCategories()
                .FirstOrDefault(c => c.Name == categoryName);

            if (category != null)
            {
                foreach (var product in category.Products)
                {
                    listBoxProducts.Items.Add($"{product.Name} - {product.CaloriesPer100g} kcal");
                }
            }
        }

        private void buttonAddToRation_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem == null) return;

            string selectedCategory = listBoxCategories.SelectedItem.ToString();
            string productInfo = listBoxProducts.SelectedItem.ToString();
            string productName = productInfo.Split('-')[0].Trim();

            var category = _facade.CatalogService.GetAllCategories()
                .FirstOrDefault(c => c.Name == selectedCategory);

            if (category == null) return;

            var product = category.Products.FirstOrDefault(p => p.Name == productName);
            if (product == null) return;

            if (!double.TryParse(textBoxWeight.Text, out double weight))
                weight = 100; // default 100 г

            // Добавляем в первый MealTime (например, Breakfast)
            var meal = _ration.MealTimes.First();
            _facade.MealService.AddProduct(meal, product, weight);

            UpdateRationList();
        }

        private void UpdateRationList()
        {
            listBoxRation.Items.Clear();

            foreach (var meal in _ration.MealTimes)
            {
                foreach (var kv in meal.Products)
                {
                    listBoxRation.Items.Add($"{kv.Key.Name} - {kv.Value}g - {kv.Key.CaloriesPer100g * kv.Value / 100.0:F1} kcal");
                }
            }

            labelTotals.Text = $"Total: {_ration.TotalCalories:F1} kcal, " +
                               $"{_ration.TotalProteins:F1}g P, " +
                               $"{_ration.TotalFats:F1}g F, " +
                               $"{_ration.TotalCarbs:F1}g C";
        }
    }
}
