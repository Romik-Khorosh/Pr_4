using Microsoft.EntityFrameworkCore;
using Pr_4.Models;
using System.Data;


namespace Pr_4
{
    public partial class FormTypes : Form
    {
        private PartnersContext db;

        public FormTypes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Создает экземпляр контекста базы данных (AppContext)
            this.db = new PartnersContext();
            this.db.TypesOfPartners.Load();
            this.dataGridViewTypes.DataSource = this.db.TypesOfPartners.Local.
                OrderBy(o => o.TypeOfPartner).ToList();

            // сокрытие некоторых столбцов
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["Partners"].Visible = false;

            // изменение названий заголовков столбцов
            dataGridViewTypes.Columns["TypeOfPartner"].HeaderText = "Типы партнеров";
        }

        private void FormTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
