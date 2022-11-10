using ArraySumLibrary;
using Serilog;
using Serilog.Core;

namespace ArraySumWinForms
{
    public partial class MainF : Form
    {
        SLogger sLogger;
        ArraySumTest arraySumTest;
        public MainF()
        {
            InitializeComponent();
            sLogger = new SLogger();
            arraySumTest = new ArraySumTest();
        }

        private int[]? ConvertTextToPositiveInt(TextBox _N, TextBox _a, TextBox _b)
        {
            try
            {
                int[] Res = new int[3];
                int.TryParse(_N.Text, out Res[0]);
                if (Res[0] <= 0)
                    return null;
                int.TryParse(_a.Text, out Res[1]);
                int.TryParse(_b.Text, out Res[2]);
                if (Res[1] >= Res[2])
                    return null;
                return Res;
            }
            catch (Exception ex)
            {
                rtb_Res.Text = ex.ToString();
                Log.Fatal(ex, "ConvertTextToPositiveInt");
                return null;
            }
        }

        private void btn_SamArrayElements_Click(object sender, EventArgs e)
        {
            int[]? Res = ConvertTextToPositiveInt(tb_N, tb_a, tb_b);
            if (Res != null)
            {
                rtb_Res.Text = arraySumTest.SumArrayElementsTestSpeed(Res[0], Res[1], Res[2]).ToString();
            }
            else
                MessageBox.Show("Ошбка в параметрах генерируемого массива", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}