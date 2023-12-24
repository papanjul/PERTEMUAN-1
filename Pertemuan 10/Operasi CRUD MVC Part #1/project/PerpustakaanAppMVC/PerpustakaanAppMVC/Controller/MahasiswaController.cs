using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using PerpustakaanAppMVC.Model.Entity;
using PerpustakaanAppMVC.Model.Repository;
using PerpustakaanAppMVC.Model.Context;

namespace PerpustakaanAppMVC.Controller
{
    public class MahasiswaController
    {
        private MahasiswaRepository _repository;

        public int Create(Mahasiswa mhs)
        {
            int result = 0;
            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(mhs.Npm))
            {
                MessageBox.Show("NPM harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(mhs.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(mhs.Angkatan))
            {
                MessageBox.Show("Angkatan harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new MahasiswaRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(mhs);
            }
            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil disimpan !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data mahasiswa gagal disimpan !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
        public List<Mahasiswa> ReadAll()
        {
            // membuat objek collection
            List<Mahasiswa> list = new List<Mahasiswa>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new MahasiswaRepository(context);
                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }
        public int Update(Mahasiswa mhs)
        {
            int result = 0;

            // Check if the NPM exists
            if (string.IsNullOrEmpty(mhs.Npm))
            {
                MessageBox.Show("NPM harus diisi untuk melakukan pembaruan data !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Check if the Mahasiswa with the specified NPM exists
            if (ReadByNama(mhs.Npm) == null)
            {
                MessageBox.Show("Data mahasiswa dengan NPM " + mhs.Npm + " tidak ditemukan !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new MahasiswaRepository(context);
                result = _repository.Update(mhs);
            }

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil diperbarui !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data mahasiswa gagal diperbarui !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int Delete(string npm)
        {
            int result = 0;

            // Check if the NPM exists
            if (string.IsNullOrEmpty(npm))
            {
                MessageBox.Show("NPM harus diisi untuk melakukan penghapusan data !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Check if the Mahasiswa with the specified NPM exists
            if (ReadByNama(npm) == null)
            {
                MessageBox.Show("Data mahasiswa dengan NPM " + npm + " tidak ditemukan !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new MahasiswaRepository(context);
                result = _repository.Delete(npm);
            }

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil dihapus !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data mahasiswa gagal dihapus !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        // Add a method to retrieve Mahasiswa by NPM for validation
        public List<Mahasiswa> ReadByNama(string nama)
        {
            List<Mahasiswa> list = new List<Mahasiswa>();

            using (DbContext context = new DbContext())
            {
                _repository = new MahasiswaRepository(context);
                list = _repository.ReadByNama(nama);
            }
            return list;
        }
    }
}
