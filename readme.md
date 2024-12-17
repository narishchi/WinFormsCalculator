# Calculator

by นริศรา มาตย์สุด,
673450037-2,
Computer and Infomation Science, KKU

# การรับและการแสดงผลข้อมูล

รับข้อมูลจากผู้ใช้งาน และทำงานผ่านการกดปุ่มเพื่อคำนวนตัวเลข

## ปุ่มบวก

```
private void button1_Click(object sender, EventArgs e)
{
    // ข้อความตัวอักษร
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    // convert string to number (integer)
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    // int ทำให้เราสามารถทำการ + - * / ได้
    int iResult = iNum1 + iNum2;
    // ที่ตัวแปรชื่อ result
    // มีคุณสมบัติชื่อ Text
    result.Text = iResult.ToString();
}
```

### รับข้อมูล

ตัวอย่าง

```
string inputNum1 = nNum1.Text;
string inputNum2 = nNum2.Text;

```

### แปลงชนิดของข้อมูล

ตัวอย่าง

```
int iNum1 = Int32.Parse(inputNum1);
int iNum2 = Int32.Parse(inputNum2);

```

### คำนวนผลลัพท์

ตัวอย่าง

```
int iResult = iNum1 + iNum2;

```

### แสดงผล

ตัวอย่าง

```
Result.Text = iResult.ToString();

```

## ปุ่มลบ

```
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
```

## ปุ่มคูณ

```
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
```


## ปุ่มหาร

```
// ปุ่มคูณ
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
```

## ปุ่มลบข้อมูล

```
 // ปุ่มลบข้อมูล
            nNum1.Text = "";
            nNum2.Text = "";
            rResult.Text = "";
```
