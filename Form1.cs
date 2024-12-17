namespace WinFormsCalculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ปุ่มบวก
            // ข้อความ
            string inputNum1 = nNum1.Text;
            string inputNum2 = nNum2.Text;

            // แปลงจากข้อความให้เป้นตัวเลขก่อน
            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);

            // int สามารถทำการ + - * / ได้
            int iResult = iNum1 + iNum2;

            // ที่ตัวเเปรชื่อ result
            // มีคุณสมบัติชื่อ Text
            rResult.Text = iResult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ปุ่มคูณ
            // ข้อความ
            string inputNum1 = nNum1.Text;
            string inputNum2 = nNum2.Text;

            // แปลงจากข้อความให้เป้นตัวเลขก่อน
            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);

            // int สามารถทำการ + - * / ได้
            int iResult = iNum1 * iNum2;

            // ที่ตัวเเปรชื่อ result
            // มีคุณสมบัติชื่อ Text
            rResult.Text = iResult.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // ปุ่มลบ
            // ข้อความ
            string inputNum1 = nNum1.Text;
            string inputNum2 = nNum2.Text;

            // แปลงจากข้อความให้เป้นตัวเลขก่อน
            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);

            // int สามารถทำการ + - * / ได้
            int iResult = iNum1 - iNum2;

            // ที่ตัวเเปรชื่อ result
            // มีคุณสมบัติชื่อ Text
            rResult.Text = iResult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ปุ่มหาร
            // ข้อความ
            string inputNum1 = nNum1.Text;
            string inputNum2 = nNum2.Text;

            // แปลงจากข้อความให้เป้นตัวเลขก่อน
            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);

            // int สามารถทำการ + - * / ได้
            int iResult = iNum1 / iNum2;

            // ที่ตัวเเปรชื่อ result
            // มีคุณสมบัติชื่อ Text
            rResult.Text = iResult.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ปุ่มลบข้อมูล
            nNum1.Text = "";
            nNum2.Text = "";
            rResult.Text = "";
        }
    }
}
