using System;
using System.Windows.Forms;

namespace calc
{
    public partial class Calculator : Form
    {
        string x = "";
        string y = "";
        string v = "";
        string action = "";
        bool op = false;
        bool calculated = false;
        bool numentry = false;
        bool dotentry = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void number_1_Click(object sender, EventArgs e)
        {
            if (op == false)
            {
                if (calculated == true)
                {
                    calculated = false;
                    x = "1";
                    output.Text = x; output.Refresh();
                }
                else
                {
                    x = x + "1";
                    output.Text = x; output.Refresh();
                }
            }
            else
            {
                y = y + "1";
                output.Text = y; output.Refresh();
            }
            numentry = true;
        }

        private void number_2_Click(object sender, EventArgs e)
        {
            if (op == false)
            {
                if (calculated == true)
                {
                    calculated = false;
                    x = "2";
                    output.Text = x; output.Refresh();
                }
                else
                {
                    x = x + "2";
                    output.Text = x; output.Refresh();
                }
            }
            else
            {
                y = y + "2";
                output.Text = y; output.Refresh();
            }
            numentry = true;
        }

        private void number_3_Click(object sender, EventArgs e)
        {
            if (op == false)
            {
                if (calculated == true)
                {
                    calculated = false;
                    x = "3";
                    output.Text = x; output.Refresh();
                }
                else
                {
                    x = x + "3";
                    output.Text = x; output.Refresh();
                }
            }
            else
            {
                y = y + "3";
                output.Text = y; output.Refresh();
            }
            numentry = true;
        }

        private void number_4_Click(object sender, EventArgs e)
        {
            if (op == false)
            {
                if (calculated == true)
                {
                    calculated = false;
                    x = "4";
                    output.Text = x; output.Refresh();
                }
                else
                {
                    x = x + "4";
                    output.Text = x; output.Refresh();
                }
            }
            else
            {
                y = y + "4";
                output.Text = y; output.Refresh();
            }
            numentry = true;
        }

        private void number_5_Click(object sender, EventArgs e)
        {
            if (op == false)
            {
                if (calculated == true)
                {
                    calculated = false;
                    x = "5";
                    output.Text = x; output.Refresh();
                }
                else
                {
                    x = x + "5";
                    output.Text = x; output.Refresh();
                }
            }
            else
            {
                y = y + "5";
                output.Text = y; output.Refresh();
            }
            numentry = true;
        }

        private void number_6_Click(object sender, EventArgs e)
        {
            if (op == false)
            {
                if (calculated == true)
                {
                    calculated = false;
                    x = "6";
                    output.Text = x; output.Refresh();
                }
                else
                {
                    x = x + "6";
                    output.Text = x; output.Refresh();
                }
            }
            else
            {
                y = y + "6";
                output.Text = y; output.Refresh();
            }
            numentry = true;
        }

        private void number_7_Click(object sender, EventArgs e)
        {
            if (op == false)
            {
                if (calculated == true)
                {
                    calculated = false;
                    x = "7";
                    output.Text = x; output.Refresh();
                }
                else
                {
                    x = x + "7";
                    output.Text = x; output.Refresh();
                }
            }
            else
            {
                y = y + "7";
                output.Text = y; output.Refresh();
            }
            numentry = true;
        }

        private void number_8_Click(object sender, EventArgs e)
        {
            if (op == false)
            {
                if (calculated == true)
                {
                    calculated = false;
                    x = "8";
                    output.Text = x; output.Refresh();
                }
                else
                {
                    x = x + "8";
                    output.Text = x; output.Refresh();
                }
            }
            else
            {
                y = y + "8";
                output.Text = y; output.Refresh();
            }
            numentry = true;
        }

        private void number_9_Click(object sender, EventArgs e)
        {
            if (op == false)
            {
                if (calculated == true)
                {
                    calculated = false;
                    x = "9";
                    output.Text = x; output.Refresh();
                }
                else
                {
                    x = x + "9";
                    output.Text = x; output.Refresh();
                }
            }
            else
            {
                y = y + "9";
                output.Text = y; output.Refresh();
            }
            numentry = true;
        }

        private void number_0_Click(object sender, EventArgs e)
        {
            if (op == false)
            {
                if (calculated == true)
                {
                    calculated = false;
                    x = "0";
                    output.Text = x; output.Refresh();
                }
                else
                {
                    x = x + "0";
                    output.Text = x; output.Refresh();
                }
            }
            else
            {
                y = y + "0";
                output.Text = y; output.Refresh();
            }
            numentry = true;
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (dotentry == false)
            {
                if (op == false)
                {
                    if (calculated == true)
                    {
                        calculated = false;
                        x = ".";
                        output.Text = x; output.Refresh();
                        dotentry = true;
                    }
                    else
                    {
                        x = x + ".";
                        output.Text = x; output.Refresh();
                        dotentry = true;
                    }
                }
                else
                {
                    y = y + ".";
                    output.Text = y; output.Refresh();
                    dotentry = true;
                }
            }
        }

        private void lastAns_Click(object sender, EventArgs e)
        {
            if (op == false)
            {
                if (calculated == true)
                {
                    calculated = false;
                    x = v;
                    output.Text = x; output.Refresh();
                }
                else
                {
                    x = v;
                    output.Text = x; output.Refresh();
                }
            }
            else
            {
                y = v;
                output.Text = y; output.Refresh();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (numentry == true)
            {
                if (op == true)
                {
                    if (action == "+")
                    {
                        float z = float.Parse(x) + float.Parse(y);
                        string inp = ($"{x} + {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "−")
                    {
                        float z = float.Parse(x) - float.Parse(y);
                        string inp = ($"{x} − {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "×")
                    {
                        float z = float.Parse(x) * float.Parse(y);
                        string inp = ($"{x} × {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "÷")
                    {
                        float z = float.Parse(x) / float.Parse(y);
                        string inp = ($"{x} ÷ {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "√Ans")
                    {
                        float z = (float)Math.Sqrt(float.Parse(x));
                        string inp = ($"√Ans = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "Ans^2")
                    {
                        float z = float.Parse(x) * float.Parse(x);
                        string inp = ($"Ans^2 = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    output.Text = "+"; output.Refresh();
                    action = "+";
                }
                else
                {
                    op = true;
                    output.Text = "+"; output.Refresh();
                    action = "+";
                }
                numentry = false;
                dotentry = false;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (numentry == true)
            {
                if (op == true)
                {
                    if (action == "+")
                    {
                        float z = float.Parse(x) + float.Parse(y);
                        string inp = ($"{x} + {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "−")
                    {
                        float z = float.Parse(x) - float.Parse(y);
                        string inp = ($"{x} − {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "×")
                    {
                        float z = float.Parse(x) * float.Parse(y);
                        string inp = ($"{x} × {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "÷")
                    {
                        float z = float.Parse(x) / float.Parse(y);
                        string inp = ($"{x} ÷ {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "√Ans")
                    {
                        float z = (float)Math.Sqrt(float.Parse(x));
                        string inp = ($"√Ans = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "Ans^2")
                    {
                        float z = float.Parse(x) * float.Parse(x);
                        string inp = ($"Ans^2 = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    output.Text = "−"; output.Refresh();
                    action = "−";
                }
                else
                {
                    op = true;
                    output.Text = "−"; output.Refresh();
                    action = "−";
                }
                numentry = false;
                dotentry = false;
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (numentry == true)
            {
                if (op == true)
                {
                    if (action == "+")
                    {
                        float z = float.Parse(x) + float.Parse(y);
                        string inp = ($"{x} + {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "−")
                    {
                        float z = float.Parse(x) - float.Parse(y);
                        string inp = ($"{x} − {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "×")
                    {
                        float z = float.Parse(x) * float.Parse(y);
                        string inp = ($"{x} × {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "÷")
                    {
                        float z = float.Parse(x) / float.Parse(y);
                        string inp = ($"{x} ÷ {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "√Ans")
                    {
                        float z = (float)Math.Sqrt(float.Parse(x));
                        string inp = ($"√Ans = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "Ans^2")
                    {
                        float z = float.Parse(x) * float.Parse(x);
                        string inp = ($"Ans^2 = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    output.Text = "×"; output.Refresh();
                    action = "×";
                }
                else
                {
                    op = true;
                    output.Text = "×"; output.Refresh();
                    action = "×";
                }
                numentry = false;
                dotentry = false;
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (numentry == true)
            {
                if (op == true)
                {
                    if (action == "+")
                    {
                        float z = float.Parse(x) + float.Parse(y);
                        string inp = ($"{x} + {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "−")
                    {
                        float z = float.Parse(x) - float.Parse(y);
                        string inp = ($"{x} − {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "×")
                    {
                        float z = float.Parse(x) * float.Parse(y);
                        string inp = ($"{x} × {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "÷")
                    {
                        float z = float.Parse(x) / float.Parse(y);
                        string inp = ($"{x} ÷ {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "√Ans")
                    {
                        float z = (float)Math.Sqrt(float.Parse(x));
                        string inp = ($"√Ans = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "Ans^2")
                    {
                        float z = float.Parse(x) * float.Parse(x);
                        string inp = ($"Ans^2 = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    output.Text = "÷"; output.Refresh();
                    action = "÷";
                }
                else
                {
                    op = true;
                    output.Text = "÷"; output.Refresh();
                    action = "÷";
                }
                numentry = false;
                dotentry = false;
            }
        }

        private void lessthan_Click(object sender, EventArgs e)
        {
            if (numentry == true)
            {
                if (op == true)
                {
                    if (action == "+")
                    {
                        float z = float.Parse(x) + float.Parse(y);
                        string inp = ($"{x} + {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "−")
                    {
                        float z = float.Parse(x) - float.Parse(y);
                        string inp = ($"{x} − {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "×")
                    {
                        float z = float.Parse(x) * float.Parse(y);
                        string inp = ($"{x} × {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "÷")
                    {
                        float z = float.Parse(x) / float.Parse(y);
                        string inp = ($"{x} ÷ {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "√Ans")
                    {
                        float z = (float)Math.Sqrt(float.Parse(x));
                        string inp = ($"√Ans = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "Ans^2")
                    {
                        float z = float.Parse(x) * float.Parse(x);
                        string inp = ($"Ans^2 = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    output.Text = "√Ans"; output.Refresh();
                    action = "√Ans";
                }
                else
                {
                    op = true;
                    output.Text = "√Ans"; output.Refresh();
                    action = "√Ans";
                }
                numentry = false;
                dotentry = false;
            }
        }

        private void morethan_Click(object sender, EventArgs e)
        {
            if (numentry == true)
            {
                if (op == true)
                {
                    if (action == "+")
                    {
                        float z = float.Parse(x) + float.Parse(y);
                        string inp = ($"{x} + {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "−")
                    {
                        float z = float.Parse(x) - float.Parse(y);
                        string inp = ($"{x} − {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "×")
                    {
                        float z = float.Parse(x) * float.Parse(y);
                        string inp = ($"{x} × {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "÷")
                    {
                        float z = float.Parse(x) / float.Parse(y);
                        string inp = ($"{x} ÷ {y} = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "√Ans")
                    {
                        float z = (float)Math.Sqrt(float.Parse(x));
                        string inp = ($"√Ans = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    else if (action == "Ans^2")
                    {
                        float z = float.Parse(x) * float.Parse(x);
                        string inp = ($"Ans^2 = {z}");
                        input.Text = inp; input.Refresh();
                        v = z.ToString();
                        x = z.ToString();
                        y = "";
                        output.Text = x; output.Refresh();
                    }
                    output.Text = "Ans^2"; output.Refresh();
                    action = "Ans^2";
                }
                else
                {
                    op = true;
                    output.Text = "Ans^2"; output.Refresh();
                    action = "Ans^2";
                }
                numentry = false;
                dotentry = false;
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (action == "+")
            {
                float z = float.Parse(x) + float.Parse(y);
                string inp = ($"{x} + {y} = {z}");
                input.Text = inp; input.Refresh();
                v = z.ToString();
                x = z.ToString();
                y = "";
                output.Text = x; output.Refresh();
            }
            else if (action == "−")
            {
                float z = float.Parse(x) - float.Parse(y);
                string inp = ($"{x} − {y} = {z}");
                input.Text = inp; input.Refresh();
                v = z.ToString();
                x = z.ToString();
                y = "";
                output.Text = x; output.Refresh();
            }
            else if (action == "×")
            {
                float z = float.Parse(x) * float.Parse(y);
                string inp = ($"{x} × {y} = {z}");
                input.Text = inp; input.Refresh();
                v = z.ToString();
                x = z.ToString();
                y = "";
                output.Text = x; output.Refresh();
            }
            else if (action == "÷")
            {
                float z = float.Parse(x) / float.Parse(y);
                string inp = ($"{x} ÷ {y} = {z}");
                input.Text = inp; input.Refresh();
                v = z.ToString();
                x = z.ToString();
                y = "";
                output.Text = x; output.Refresh();
            }
            else if (action == "√Ans")
            {
                float z = (float)Math.Sqrt(float.Parse(x));
                string inp = ($"√Ans = {z}");
                input.Text = inp; input.Refresh();
                v = z.ToString();
                x = z.ToString();
                y = "";
                output.Text = x; output.Refresh();
            }
            else if (action == "Ans^2")
            {
                float z = float.Parse(x) * float.Parse(x);
                string inp = ($"Ans^2 = {z}");
                input.Text = inp; input.Refresh();
                v = z.ToString();
                x = z.ToString();
                y = "";
                output.Text = x; output.Refresh();
            }
            op = false;
            calculated = true;
        }

        private void clearall_Click(object sender, EventArgs e)
        {
            x = "";
            y = "";
            v = "";
            action = "";
            op = false;
            calculated = false;
            output.Text = ""; output.Refresh();
            input.Text = ""; input.Refresh();
            numentry = false;
            dotentry = false;
        }
    }
}
