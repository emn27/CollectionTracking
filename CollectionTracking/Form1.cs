using CollectionTracking.Business.Abstract;
using CollectionTracking.Business.DependencyResolvers.Ninject;
using CollectionTracking.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace CollectionTracking
{
    public partial class frmFilm : Form
    {
        private IFilmService _filmService;


        public frmFilm()
        {
            InitializeComponent();
            _filmService = InstanceFactory.GetInstance<IFilmService>();
        }

        private void LoadFilms()
        {
            dgwFilms.DataSource = _filmService.GetAll();
        }

        private void frmFilm_Load(object sender, EventArgs e)
        {
            LoadFilms();
        }

        private void dgwFilms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxFilmNameUpdate.Text = dgwFilms.CurrentRow.Cells[1].Value.ToString();
            tbxTypeUpdate.Text = dgwFilms.CurrentRow.Cells[2].Value.ToString();
            tbxPublishDateUpdate.Text = dgwFilms.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _filmService.Add(new Film
            {
                Name = tbxFilmName.Text,
                Type = tbxType.Text,
                PublishDate = DateTime.Parse(tbxPublishDate.Text)
            });
            MessageBox.Show("Film eklendi!");
            LoadFilms();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _filmService.Update(new Film
            {
                Id = int.Parse(dgwFilms.CurrentRow.Cells[0].Value.ToString()),
                Name = tbxFilmNameUpdate.Text,
                Type = tbxTypeUpdate.Text,
                PublishDate = DateTime.Parse(tbxPublishDateUpdate.Text)
            });
            MessageBox.Show("Film güncellendi!");
            LoadFilms();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwFilms.CurrentRow.Cells[0].Value);
            _filmService.Delete(id);
            MessageBox.Show("Film silindi!");
            LoadFilms();
        }
    }
}