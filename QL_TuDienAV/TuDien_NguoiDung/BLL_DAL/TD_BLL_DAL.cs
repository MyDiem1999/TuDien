using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    
    public class TD_BLL_DAL
    {
        QLTDDataContext qltd = new QLTDDataContext();
       public string loaitu, phienam, nghia,tuvung;
        
        public TD_BLL_DAL()
        {

        }

        public void loadKhachHang(string tendn,string pass)
        {
            var c = qltd.KHACHHANGs.SingleOrDefault(t => t.TAIKHOAN == tendn && t.MATKHAU==pass);
            if (c != null)  MessageBox.Show("Đăng nhập thành công");
            else MessageBox.Show("Không có tài khoản này!");
        }

        public bool KTTaiKhoan(string tendn,string pass)
        {
            if (qltd.KHACHHANGs.SingleOrDefault(t => t.TAIKHOAN == tendn && t.MATKHAU== pass) == null)
            {
                return true;
            }
            else
            { return false;
                
            }
        }

        public bool KTTenTaiKhoan(string tendn)
        {
            if (qltd.KHACHHANGs.SingleOrDefault(t => t.TAIKHOAN == tendn) == null)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public string NghiaLoai(object v)
        {
            throw new NotImplementedException();
        }

        public bool TraKQKTTK(string tendn)
        {
            if (KTTenTaiKhoan(tendn) == false)
                return true;
            else return false;
        }

        public string loadPass(string tendn)
        {
            return qltd.KHACHHANGs.SingleOrDefault(t => t.TAIKHOAN == tendn).MATKHAU.ToString();
        }

        public void themKH(string tendn, string pass, int diachi, DateTime ngaysinh, bool gioitinh, string tennd, string sdt, string email)
        {
            if (KTTaiKhoan(tendn, pass) == true)
            {
                KHACHHANG kh = new KHACHHANG();
                kh.TAIKHOAN = tendn;
                kh.MATKHAU = pass;
                kh.DIACHI = diachi;
                kh.NGAYSINH = ngaysinh;
                kh.GIOITINH = gioitinh;
                kh.TENNGUOIDUNG = tennd;
                kh.SDT = sdt;
                kh.EMAIL = email;

                qltd.KHACHHANGs.InsertOnSubmit(kh);
                qltd.SubmitChanges();
                MessageBox.Show("Thêm thành công");
            }
            else MessageBox.Show("Thêm tài khoản thât bại");
        }

        public IQueryable<TINHTHANH> loadTT()
        {
            return qltd.TINHTHANHs.Select(t => t);
        }

        public int loadDiaChi(string tendn)
        {
            
            return qltd.KHACHHANGs.SingleOrDefault(t=>t.TAIKHOAN==tendn).DIACHI.Value;
        }

        public bool loadGioiTinh(string tendn)
        {
            return qltd.KHACHHANGs.SingleOrDefault(t => t.TAIKHOAN == tendn).GIOITINH.Value;
        }

        public string loadTenNguoiDung(string tendn)
        {
            return qltd.KHACHHANGs.SingleOrDefault(t => t.TAIKHOAN == tendn).TENNGUOIDUNG.ToString();
        }

        public DateTime loadNgaySinh(string tendn)
        {
            return qltd.KHACHHANGs.SingleOrDefault(t => t.TAIKHOAN == tendn).NGAYSINH.Value;
        }

        public string loadEmail(string tendn)
        {
            return qltd.KHACHHANGs.SingleOrDefault(t => t.TAIKHOAN == tendn).EMAIL.ToString();
        }

        public string loadSDT(string tendn)
        {
            return qltd.KHACHHANGs.SingleOrDefault(t => t.TAIKHOAN == tendn).SDT.ToString();
        }

        public void capnhatTTKH(string tendn, string pass, int diachi, DateTime ngaysinh, bool gioitinh, string tennd, string sdt, string email)
        {
            if (KTTaiKhoan(tendn, pass) == false)
            {
                KHACHHANG kh = qltd.KHACHHANGs.SingleOrDefault(t => t.TAIKHOAN == tendn && t.MATKHAU == pass);
                kh.DIACHI = diachi;
                kh.NGAYSINH = ngaysinh;
                kh.GIOITINH = gioitinh;
                kh.TENNGUOIDUNG = tennd;
                kh.EMAIL = email;
                kh.SDT = sdt;
                qltd.SubmitChanges();
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            else MessageBox.Show("Cập nhật thông tin thất bại");
        }

        public void capnhatMatKhau(string tendn,string pass)
        {
            if (KTTaiKhoan(tendn, pass) == false)
            {
                KHACHHANG kh = qltd.KHACHHANGs.SingleOrDefault(t => t.TAIKHOAN == tendn && t.MATKHAU == pass);
                kh.MATKHAU = pass;
                qltd.SubmitChanges();
                MessageBox.Show("Thay đổi mật khẩu thành công");
            }
            else MessageBox.Show("Thay đổi mật khẩu thất bại");
        }

        public IQueryable<TU> loadTU()
        {
            return qltd.TUs.Select(t => t);
        }

        public string NghiaLoai(string tu)
        {
            return qltd.LOAITUs.SingleOrDefault(t=>t.MALOAI==tu).NGHIALOAITU;
        }


        public List<string> DichNghia(string tu)
        {
            List<string> lst = new List<string>();
            var result = qltd.TUs.Where(t=>t.TUVUNG==tu).Select(t => new { ltu = t.MALOAI, pa = t.PHIENAM, nghia = t.NGHIA });
                foreach (var item in result)
                {
                    loaitu = "Loại từ: " + "\t"+NghiaLoai(item.ltu);
                    phienam = "Phiên âm: " + "\t"+item.pa;
                    nghia = item.nghia;
                }
                lst.Add(loaitu);
            lst.Add(phienam);
            lst.Add("Nghĩa: ");
                foreach (string s in nghia.Split(';',','))
                {
                    lst.Add("\t"+s.Trim());
                }
            
            
            return lst.ToList();
        }

        public bool ktTuYT(string tu,string tendn)
        {
            var result = qltd.TUYEUTHICHes.Where(t => t.TAIKHOAN == tendn && t.TUVUNG == tu).FirstOrDefault();
            if (result != null) return true;
            else return false;
        }
        public void themTuYT(string tendn, string tu)
        {
            if (ktTuYT(tu, tendn) == false)
            {
                TUYEUTHICH tuyt = new TUYEUTHICH();
                tuyt.TAIKHOAN = tendn;
                tuyt.TUVUNG = tu;
                string result = qltd.TUs.SingleOrDefault(t => t.TUVUNG == tu).MALOAI;
                tuyt.MALOAI = result;
                qltd.TUYEUTHICHes.InsertOnSubmit(tuyt);
                qltd.SubmitChanges();
                MessageBox.Show("Đã yêu thích");
            }
            else 
            { 
                TUYEUTHICH tuyt = qltd.TUYEUTHICHes.Where(t => t.TUVUNG == tu).FirstOrDefault();
                qltd.TUYEUTHICHes.DeleteOnSubmit(tuyt);
                qltd.SubmitChanges();
                MessageBox.Show("Hết thích rồi");
            }    
        }

        public IEnumerable<TUYEUTHICH> loadTUYT(string tk)
        {
            return qltd.TUYEUTHICHes.Select(t => t).Where(t=>t.TAIKHOAN==tk);

        }

        public IQueryable<LOAITU> Loaitu()
        {
            return qltd.LOAITUs.Select(t => t);
        }

        public IQueryable<TuDienKhachHang> loadTD(string tendn)
        {
            return qltd.TuDienKhachHangs.Select(t => t).Where(t=>t.TaiKhoan==tendn);
        }


        public bool ktTDCuaBan(string tendn, string tu)
        {
            if(qltd.TuDienKhachHangs.Where(t=>t.TaiKhoan==tendn && t.Tu==tu).Select(t=>t)==null)
            {
                return true;
            }
            return false;
        }

        public void themTuDienCuaBan(string tu, string loai, string phienam, string nghia, string tk)
        {
            if(ktTDCuaBan(tk,tu)==false)
            {
                TuDienKhachHang td = new TuDienKhachHang();
                td.Tu = tu;
                td.LoaiTu = loai;
                td.PhienAm = phienam;
                td.Nghia = nghia;
                td.TaiKhoan = tk;
                qltd.TuDienKhachHangs.InsertOnSubmit(td);
                qltd.SubmitChanges();
                MessageBox.Show("Thêm từ thành công");
            }    
        }
    }
}


