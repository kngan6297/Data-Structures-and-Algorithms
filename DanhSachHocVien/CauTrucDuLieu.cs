class StudentNode
{
	public int MaSo;
	public string HoTen;
	public string GioiTinh;
	public int DiemTB;
	public StudentNode next;

	public StudentNode(int MaSo, string HoTen, string GioiTinh, int DiemTB, StudentNode next)
    {
		this.MaSo = MaSo;
		this.HoTen = HoTen;
		this.GioiTinh = GioiTinh;
		this.DiemTB = DiemTB;
		this.next = next;
    }
}
