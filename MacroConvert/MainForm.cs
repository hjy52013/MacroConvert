using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MacroConvert
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        Dictionary<string, string> name = new Dictionary<string, string>();
        public MainForm()
        {
            InitializeComponent();
            InitDic();
        }


        private void simpleButtonComfirm_Click(object sender, EventArgs e)
        {
            string input = memoEditInput.Text;
            string[] inputs = input.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string[] outputs = new string[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                string result = inputs[i];
                string key = GetKey(inputs[i]);
                if (key != null)
                {
                    try
                    {
                        result = result.Replace(key, name[key]);
                    } catch (KeyNotFoundException)
                    {
                        outputs[i] = result;
                        continue;
                    }

                }
                outputs[i] = result;
            }
            memoEditOutput.Lines = outputs;
        }

        private string GetKey(string target)
        {
            string temp = null;
            int start = -1;
            int end = -1;
            for (int i = 0; i < target.Length; i++)
            {
                if (IsChineseCharater(target[i]))
                {
                    start = i;
                    break;
                }
            }
            if (start != -1)
            {
                end = start + 1;
                for (int i = start + 1; i < target.Length; i++)
                {
                    if (target[i].Equals('I'))
                    {
                        try
                        {
                            if (target[i + 2].Equals('I'))
                            {
                                end = i + 2;
                            }
                            else
                            {
                                end = i + 1;
                            }
                            break;
                        } catch (IndexOutOfRangeException)
                        {
                            end = i + 1;
                        }
                        
                    }
                    if (!IsChineseCharater(target[i]))
                    {
                        end = i - 1;
                        break;
                    }

                }
                temp = target.Substring(start, end - start + 1);
            }

            return temp;
        }

        private bool IsChineseCharater(char a)
        {
            if (a >= 0x4e00 && a <= 0x9fbb)
                return true;
            return false;
        }

        private void InitDic()
        {
            //制作类
            name.Add("制作","Basic Synthesis");
            name.Add("中级制作", "Standard Synthesis");
            name.Add("模范制作II", "Careful Synthesis II");
            name.Add("模范制作III", "Careful Synthesis III");
            name.Add("注视制作", "Focused Synthesis");
            name.Add("元素之美名", "Name of the Elements");
            name.Add("元素之印记", "Brand of the Elements");
            name.Add("火之美名", "Name of the Elements");
            name.Add("火之印记", "Brand of the Elements");

            //加工类
            name.Add("仓促", "Hasty Touch");
            name.Add("仓促II", "Hasty Touch II");
            name.Add("加工", "Basic Touch");
            name.Add("中级加工", "Standard Touch");
            name.Add("上级加工", "Advanced Touch");
            name.Add("俭约加工", "Prudent Touch");
            name.Add("专心加工", "Patient Touch");
            name.Add("注视加工", "Focusd Touch");
            name.Add("集中加工", "Precise Touch");

            //Buff类
            name.Add("坚信", "Muscle Memory");
            name.Add("安逸", "Comfort Zone");
            name.Add("内静", "Inner Quiet");
            name.Add("稳手", "Steady Hand");
            name.Add("稳手II", "Steady Hand II");
            name.Add("精修", "Master's Mend");
            name.Add("精修II", "Master's Mend II");
            name.Add("掌握", "Manipulation");
            name.Add("掌握II", "Manipulation II");
            name.Add("改革", "Innovation");
            name.Add("阔步", "Great Strides");
            name.Add("比尔格的祝福","Byregot's Blessing");
            name.Add("观察", "Observe");
            name.Add("新颖","Ingenuity");
            name.Add("新颖II", "Ingenuity II");
            name.Add("渐进","Piece by Piece");
            name.Add("俭约", "Waste Not");
            name.Add("俭约II", "Waste Not II");

            //70级以后
            name.Add("下地加工", "Preparatory Touch");
            name.Add("再回收", "Reuse");
            name.Add("精密制作","Delicate Synthesis");

        }

        private void simpleButtonClear_Click(object sender, EventArgs e)
        {
            memoEditInput.Lines = null;
            memoEditOutput.Lines = null;
        }
    }
}
