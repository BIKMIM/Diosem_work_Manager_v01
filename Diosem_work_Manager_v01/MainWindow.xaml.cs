using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        // 작업자 체크박스를 담은 빈리스트 workerList 생성
        public List<CheckBox> workerList = new List<CheckBox>();

        public MainWindow()
        {
            InitializeComponent();

            // 작업자 체크박스가 들어있는 workerList 비움.
            workerList.Clear();
            // 리스트 안에 작업자 전원 추가(Add)
            AddWorkerToList();

        }

        private void AddWorkerToList()
        {
            // 리스트안에 작업자 전원 추가(Add)
            workerList.Add(이상엽);
            workerList.Add(강범일);
            workerList.Add(최광섭);
            workerList.Add(김진탁);
            workerList.Add(조광호);
            workerList.Add(김태영);
            workerList.Add(최현철);
            workerList.Add(신재웅);
            workerList.Add(노진성);
            workerList.Add(장다빈);
            workerList.Add(임성용);
            workerList.Add(권용덕);
            workerList.Add(조용준);
            workerList.Add(김민우);
            workerList.Add(신지호);
        }

        private void RadioBtnCheck(string name)
        {

            // 라디오버튼 1번이 선택된채로 이상엽 버튼이 눌리면
            // workerName1에 이상엽, 추가
            // 이하 라디오버튼 10번까지 동일
            if (radio1.IsChecked == true)
            {
                workerName1.Text += $"{name}, ";
            }
            else if (radio2.IsChecked == true)
            {
                workerName2.Text += $"{name}, ";
            }
            else if (radio3.IsChecked == true)
            {
                workerName3.Text += $"{name}, ";
            }
            else if (radio4.IsChecked == true)
            {
                workerName4.Text += $"{name}, ";
            }
            else if (radio5.IsChecked == true)
            {
                workerName5.Text += $"{name}, ";
            }
            else if (radio6.IsChecked == true)
            {
                workerName6.Text += $"{name}, ";
            }
            else if (radio7.IsChecked == true)
            {
                workerName7.Text += $"{name}, ";
            }
            else if (radio8.IsChecked == true)
            {
                workerName8.Text += $"{name}, ";
            }
            else if (radio9.IsChecked == true)
            {
                workerName9.Text += $"{name}, ";
            }
            else if (radio10.IsChecked == true)
            {
                workerName10.Text += $"{name}, ";
            }
        }

        private void sylee_Checked(object sender, RoutedEventArgs e)
        {

            RadioBtnCheck("이상엽");
            
        }

        private void bikang_Checked(object sender, RoutedEventArgs e)
        {
            RadioBtnCheck("강범일");
        }

        private void kschoi_Checked(object sender, RoutedEventArgs e)
        {
            RadioBtnCheck("최광섭");
        }

        private void jtkim_Checked(object sender, RoutedEventArgs e)
        {
            RadioBtnCheck("김진탁");
        }

        private void khcho_Checked(object sender, RoutedEventArgs e)
        {
            RadioBtnCheck("조광호");
        }

        private void tykim_Checked(object sender, RoutedEventArgs e)
        {
            RadioBtnCheck("김태영");
        }

        private void hcchoi_Checked(object sender, RoutedEventArgs e)
        {
            RadioBtnCheck("최현철");
        }

        private void jwshin_Checked(object sender, RoutedEventArgs e)
        {
            RadioBtnCheck("신재웅");
        }

        private void jsno_Checked(object sender, RoutedEventArgs e)
        {
            RadioBtnCheck("노진성");
        }

        private void dbjang_Checked(object sender, RoutedEventArgs e)
        {
            RadioBtnCheck("장다빈");
        }

        private void syim_Checked(object sender, RoutedEventArgs e)
        {
            RadioBtnCheck("임성용");
        }

        private void ydkwon_Checked(object sender, RoutedEventArgs e)
        {
            RadioBtnCheck("권용덕");
        }

        private void yjcho_Checked(object sender, RoutedEventArgs e)
        {
            RadioBtnCheck("조용준");
        }

        private void mwkim_Checked(object sender, RoutedEventArgs e)
        {
            RadioBtnCheck("김민우");
        }

        private void jhshin_Checked(object sender, RoutedEventArgs e)
        {
            RadioBtnCheck("신지호");
        }


        private void UncheckedName(string name)
        {
            // name 체크박스가 해제되면
            // workerName1~10까지 모든 작업에서 name 이름을 제거
            workerName1.Text = workerName1.Text.Replace($"{name}, ", "");
            workerName2.Text = workerName2.Text.Replace($"{name}, ", "");
            workerName3.Text = workerName3.Text.Replace($"{name}, ", "");
            workerName4.Text = workerName4.Text.Replace($"{name}, ", "");
            workerName5.Text = workerName5.Text.Replace($"{name}, ", "");
            workerName6.Text = workerName6.Text.Replace($"{name}, ", "");
            workerName7.Text = workerName7.Text.Replace($"{name}, ", "");
            workerName8.Text = workerName8.Text.Replace($"{name}, ", "");
            workerName9.Text = workerName9.Text.Replace($"{name}, ", "");
            workerName10.Text = workerName10.Text.Replace($"{name}, ", "");
        }



        private void sylee_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("이상엽");
            // 리스트 workerList에 다시 선택가능하도록 name 체크박스 추가(Add)
            workerList.Add(이상엽);
        }

        private void bikang_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("강범일");

            workerList.Add(강범일);
        }

        private void kschoi_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("최광섭");

            workerList.Add(최광섭);

        }

        private void jtkim_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("김진탁");

            workerList.Add(김진탁);
        }

        private void khcho_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("조광호");

            workerList.Add(조광호);
        }

        private void tykim_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("김태영");

            workerList.Add(김태영);
        }

        private void hcchoi_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("최현철");

            workerList.Add(최현철);
        }

        private void jwshin_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("신재웅");

            workerList.Add(신재웅);
        }

        private void jsno_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("노진성");

            workerList.Add(노진성);
        }

        private void dbjang_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("장다빈");

            workerList.Add(장다빈);
        }

        private void syim_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("임성용");

            workerList.Add(임성용);
        }

        private void ydkwon_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("권용덕");

            workerList.Add(권용덕);
        }

        private void yjcho_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("조용준");

            workerList.Add(조용준);
        }

        private void mwkim_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("김민우");

            workerList.Add(김민우);
        }

        private void jhshin_Unchecked(object sender, RoutedEventArgs e)
        {
            UncheckedName("신지호");

            workerList.Add(신지호);
        }

        private void resetBtn_Click(object sender, RoutedEventArgs e)
        {
            // 리셋버튼을 누르면 모든 작업자의 체크박스가 선택해제되고
            // 리스트 workerList를 Clear함.
            // 이후 다시 작업자를 선택할 수 있도록
            // 모든 작업자의 체크박스를 다시 리스트 workerList에 추가(Add)

            이상엽.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            강범일.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            최광섭.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            김진탁.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            조광호.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            김태영.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            최현철.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            신재웅.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            노진성.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            장다빈.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            임성용.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            권용덕.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            조용준.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            김민우.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            신지호.SetCurrentValue(CheckBox.IsCheckedProperty, false);

            workerList.Clear();

            AddWorkerToList();

        }

        

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            // 작업자 추가 1명 버튼을 누르면
            // OrderBy, Guid를 이용해서 랜덤 Shuffle로 리스트 값을 섞고
            // 리스트 인덱스[0] 값의 체크박스를 선택해서 실제로 체크함.
            // 이후 리스트 workerList에서 인덱스[0]의 값을 Remove로 제거.
            // 리스트는 가변인덱스라서 전체 수량이 줄어들기때문에 인덱스[0]을 반복해서 제거해도 됨.
            // 하지만 인덱스[0]을 연속 두번 사용하면 딜레이때문에 Remove에 문제가 생기니까
            // 삭제할때는 인덱스를 [0][1] ... 이런식으로 썼음.


            var shuffledworkers = workerList.OrderBy(a => Guid.NewGuid()).ToList();

            try
            {
                shuffledworkers[0].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                workerList.Remove(shuffledworkers[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("모든 작업자가 배정되었습니다.");
                //MessageBox.Show("모든 작업자가 배정되었습니다.");
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {


            var shuffledworkers = workerList.OrderBy(a => Guid.NewGuid()).ToList();

            try
            {
                shuffledworkers[0].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[1].SetCurrentValue(CheckBox.IsCheckedProperty, true);

                workerList.Remove(shuffledworkers[0]);
                workerList.Remove(shuffledworkers[1]);

                if (workerList.Count == 0)
                {
                    MessageBox.Show("모든 작업자가 배정되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("모든 작업자가 배정되었습니다.");
                //MessageBox.Show(ex.ToString());
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            var shuffledworkers = workerList.OrderBy(a => Guid.NewGuid()).ToList();

            try
            {
                shuffledworkers[0].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[1].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[2].SetCurrentValue(CheckBox.IsCheckedProperty, true);

                workerList.Remove(shuffledworkers[0]);
                workerList.Remove(shuffledworkers[1]);
                workerList.Remove(shuffledworkers[2]);

                if (workerList.Count == 0)
                {
                    MessageBox.Show("모든 작업자가 배정되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("모든 작업자가 배정되었습니다.");
                //MessageBox.Show(ex.ToString());
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            var shuffledworkers = workerList.OrderBy(a => Guid.NewGuid()).ToList();

            try
            {
                shuffledworkers[0].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[1].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[2].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[3].SetCurrentValue(CheckBox.IsCheckedProperty, true);

                workerList.Remove(shuffledworkers[0]);
                workerList.Remove(shuffledworkers[1]);
                workerList.Remove(shuffledworkers[2]);
                workerList.Remove(shuffledworkers[3]);

                if (workerList.Count == 0)
                {
                    MessageBox.Show("모든 작업자가 배정되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("모든 작업자가 배정되었습니다.");
                //MessageBox.Show(ex.ToString());
            }
        }

            private void btn5_Click(object sender, RoutedEventArgs e)
        {
            var shuffledworkers = workerList.OrderBy(a => Guid.NewGuid()).ToList();

            try
            {
                shuffledworkers[0].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[1].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[2].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[3].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[4].SetCurrentValue(CheckBox.IsCheckedProperty, true);

                workerList.Remove(shuffledworkers[0]);
                workerList.Remove(shuffledworkers[1]);
                workerList.Remove(shuffledworkers[2]);
                workerList.Remove(shuffledworkers[3]);
                workerList.Remove(shuffledworkers[4]);

                if (workerList.Count == 0)
                {
                    MessageBox.Show("모든 작업자가 배정되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("모든 작업자가 배정되었습니다.");
                //MessageBox.Show(ex.ToString());
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            var shuffledworkers = workerList.OrderBy(a => Guid.NewGuid()).ToList();

            try
            {
                shuffledworkers[0].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[1].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[2].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[3].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[4].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[5].SetCurrentValue(CheckBox.IsCheckedProperty, true);

                workerList.Remove(shuffledworkers[0]);
                workerList.Remove(shuffledworkers[1]);
                workerList.Remove(shuffledworkers[2]);
                workerList.Remove(shuffledworkers[3]);
                workerList.Remove(shuffledworkers[4]);
                workerList.Remove(shuffledworkers[5]);

                if (workerList.Count == 0)
                {
                    MessageBox.Show("모든 작업자가 배정되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("모든 작업자가 배정되었습니다.");
                //MessageBox.Show(ex.ToString());
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            var shuffledworkers = workerList.OrderBy(a => Guid.NewGuid()).ToList();

            try
            {
                shuffledworkers[0].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[1].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[2].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[3].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[4].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[5].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[6].SetCurrentValue(CheckBox.IsCheckedProperty, true);

                workerList.Remove(shuffledworkers[0]);
                workerList.Remove(shuffledworkers[1]);
                workerList.Remove(shuffledworkers[2]);
                workerList.Remove(shuffledworkers[3]);
                workerList.Remove(shuffledworkers[4]);
                workerList.Remove(shuffledworkers[5]);
                workerList.Remove(shuffledworkers[6]);

                if (workerList.Count == 0)
                {
                    MessageBox.Show("모든 작업자가 배정되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("모든 작업자가 배정되었습니다.");
                //MessageBox.Show(ex.ToString());
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            var shuffledworkers = workerList.OrderBy(a => Guid.NewGuid()).ToList();

            try
            {
                shuffledworkers[0].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[1].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[2].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[3].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[4].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[5].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[6].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[7].SetCurrentValue(CheckBox.IsCheckedProperty, true);

                workerList.Remove(shuffledworkers[0]);
                workerList.Remove(shuffledworkers[1]);
                workerList.Remove(shuffledworkers[2]);
                workerList.Remove(shuffledworkers[3]);
                workerList.Remove(shuffledworkers[4]);
                workerList.Remove(shuffledworkers[5]);
                workerList.Remove(shuffledworkers[6]);
                workerList.Remove(shuffledworkers[7]);

                if (workerList.Count == 0)
                {
                    MessageBox.Show("모든 작업자가 배정되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("모든 작업자가 배정되었습니다.");
                //MessageBox.Show(ex.ToString());
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            var shuffledworkers = workerList.OrderBy(a => Guid.NewGuid()).ToList();

            try
            {
                shuffledworkers[0].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[1].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[2].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[3].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[4].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[5].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[6].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[7].SetCurrentValue(CheckBox.IsCheckedProperty, true);
                shuffledworkers[8].SetCurrentValue(CheckBox.IsCheckedProperty, true);

                workerList.Remove(shuffledworkers[0]);
                workerList.Remove(shuffledworkers[1]);
                workerList.Remove(shuffledworkers[2]);
                workerList.Remove(shuffledworkers[3]);
                workerList.Remove(shuffledworkers[4]);
                workerList.Remove(shuffledworkers[5]);
                workerList.Remove(shuffledworkers[6]);
                workerList.Remove(shuffledworkers[7]);
                workerList.Remove(shuffledworkers[8]);

                if (workerList.Count == 0)
                {
                    MessageBox.Show("모든 작업자가 배정되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("모든 작업자가 배정되었습니다.");
                //MessageBox.Show(ex.ToString());
            }
        }

        private void UncheckNameContains()
        {
            // 전체 작업자 수만큼 for loop 돌면서
            // Text Contains에 걸리는 모든 작업자의 체크박스 체크해제
            for (int i = 0; i < 15; i++)
            {
                if (workerName1.Text.Contains("이상엽"))
                {
                    이상엽.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
                else if (workerName1.Text.Contains("강범일"))
                {
                    강범일.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
                else if (workerName1.Text.Contains("최광섭"))
                {
                    최광섭.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
                else if (workerName1.Text.Contains("김진탁"))
                {
                    김진탁.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
                else if (workerName1.Text.Contains("조광호"))
                {
                    조광호.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
                else if (workerName1.Text.Contains("김태영"))
                {
                    김태영.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
                else if (workerName1.Text.Contains("최현철"))
                {
                    최현철.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
                else if (workerName1.Text.Contains("신재웅"))
                {
                    신재웅.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
                else if (workerName1.Text.Contains("노진성"))
                {
                    노진성.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
                else if (workerName1.Text.Contains("장다빈"))
                {
                    장다빈.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
                else if (workerName1.Text.Contains("임성용"))
                {
                    임성용.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
                else if (workerName1.Text.Contains("권용덕"))
                {
                    권용덕.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
                else if (workerName1.Text.Contains("조용준"))
                {
                    조용준.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
                else if (workerName1.Text.Contains("김민우"))
                {
                    김민우.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
                else if (workerName1.Text.Contains("신지호"))
                {
                    신지호.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                }
            }
        }


        private void delBtn1_Click(object sender, RoutedEventArgs e)
        {
            // 딜리트 버튼을 누르면
            // 작업 정보에 들어 있던 모든 텍스트 Clear

            time1.Clear();
            charge1.Clear();
            line1.Clear();
            floor1.Clear();
            bay1.Clear();
            equipName1.Clear();
            equipCode1.Clear();
            equipNum1.Clear();
            chamber1.Clear();

            UncheckNameContains();

        }
        private void delBtn2_Click(object sender, RoutedEventArgs e)
        {
            time2.Clear();
            charge2.Clear();
            line2.Clear();
            floor2.Clear();
            bay2.Clear();
            equipName2.Clear();
            equipCode2.Clear();
            equipNum2.Clear();
            chamber2.Clear();

            UncheckNameContains();
        }
        private void delBtn3_Click(object sender, RoutedEventArgs e)
        {
            time3.Clear();
            charge3.Clear();
            line3.Clear();
            floor3.Clear();
            bay3.Clear();
            equipName3.Clear();
            equipCode3.Clear();
            equipNum3.Clear();
            chamber3.Clear();

            UncheckNameContains();
        }
        private void delBtn4_Click(object sender, RoutedEventArgs e)
        {
            time4.Clear();
            charge4.Clear();
            line4.Clear();
            floor4.Clear();
            bay4.Clear();
            equipName4.Clear();
            equipCode4.Clear();
            equipNum4.Clear();
            chamber4.Clear();

            UncheckNameContains();
            
        }


        private void delBtn5_Click(object sender, RoutedEventArgs e)
        {
            time5.Clear();
            charge5.Clear();
            line5.Clear();
            floor5.Clear();
            bay5.Clear();
            equipName5.Clear();
            equipCode5.Clear();
            equipNum5.Clear();
            chamber5.Clear();

            UncheckNameContains();
            
        }

        private void delBtn6_Click(object sender, RoutedEventArgs e)
        {
            time6.Clear();
            charge6.Clear();
            line6.Clear();
            floor6.Clear();
            bay6.Clear();
            equipName6.Clear();
            equipCode6.Clear();
            equipNum6.Clear();
            chamber6.Clear();

            UncheckNameContains();
        }


        private void delBtn7_Click(object sender, RoutedEventArgs e)
        {
            time7.Clear();
            charge7.Clear();
            line7.Clear();
            floor7.Clear();
            bay7.Clear();
            equipName7.Clear();
            equipCode7.Clear();
            equipNum7.Clear();
            chamber7.Clear();

            UncheckNameContains();
        }


        private void delBtn8_Click(object sender, RoutedEventArgs e)
        {
            time8.Clear();
            charge8.Clear();
            line8.Clear();
            floor8.Clear();
            bay8.Clear();
            equipName8.Clear();
            equipCode8.Clear();
            equipNum8.Clear();
            chamber8.Clear();

            UncheckNameContains();
        }


        private void delBtn9_Click(object sender, RoutedEventArgs e)
        {
            time9.Clear();
            charge9.Clear();
            line9.Clear();
            floor9.Clear();
            bay9.Clear();
            equipName9.Clear();
            equipCode9.Clear();
            equipNum9.Clear();
            chamber9.Clear();

            UncheckNameContains();
           
        }

        private void delBtn10_Click(object sender, RoutedEventArgs e)
        {
            time10.Clear();
            charge10.Clear();
            line10.Clear();
            floor10.Clear();
            bay10.Clear();
            equipName10.Clear();
            equipCode10.Clear();
            equipNum10.Clear();
            chamber10.Clear();

            UncheckNameContains();
        }

        private void sortBtn1_Click(object sender, RoutedEventArgs e)
        {
            // 정렬버튼을 누르면
            // 체크박스 선택으로 생성된 작업자 이름을 workerName.Text에서 가져와서 str에 할당
            string str = workerName1.Text;

            // 콤마(,)값으로 Split한 값을 Array result에 할당.
            string[] result = str.Split(new char[] { ',' });
            // 인덱스[15]값을 가진 result2 Array도 생성.
            string[] result2 = new string[15];
            // 정렬 후 String값을 담을 resultText 선언.
            string resultText = "";

            for (int i = 0; i < result.Length-1; i++)
            {
                // 혹시 공백이 있을지 모르니 Trim()으로 앞뒤 공백 제거
                if (result[i].Trim() == "이상엽")
                {
                    // 인덱스 순서를 미리 정해놓고 값이 같으면 정해진 인덱스에 이름값을 넣는 방식
                    result2[0] = "이상엽" + ", ";
                }
                else if (result[i].Trim() == "강범일")
                {
                    result2[1] = "강범일" + ", ";
                }
                else if (result[i].Trim() == "최광섭")
                {
                    result2[2] = "최광섭" + ", ";
                }
                else if (result[i].Trim() == "김진탁")
                {
                    result2[3] = "김진탁" + ", ";
                }
                else if (result[i].Trim() == "조광호")
                {
                    result2[4] = "조광호" + ", ";
                }
                else if (result[i].Trim() == "김태영")
                {
                    result2[5] = "김태영" + ", ";
                }
                else if (result[i].Trim() == "최현철")
                {
                    result2[6] = "최현철" + ", ";
                }
                else if (result[i].Trim() == "신재웅")
                {
                    result2[7] = "신재웅" + ", ";
                }
                else if (result[i].Trim() == "노진성")
                {
                    result2[8] = "노진성" + ", ";
                }
                else if (result[i].Trim() == "장다빈")
                {
                    result2[9] = "장다빈" + ", ";
                }
                else if (result[i].Trim() == "임성용")
                {
                    result2[10] = "임성용" + ", ";
                }
                else if (result[i].Trim() == "권용덕")
                {
                    result2[11] = "권용덕" + ", ";
                }
                else if (result[i].Trim() == "조용준")
                {
                    result2[12] = "조용준" + ", ";
                }
                else if (result[i].Trim() == "김민우")
                {
                    result2[13] = "김민우" + ", ";
                }
                else if (result[i].Trim() == "신지호")
                {
                    result2[14] = "신지호" + ", ";
                }
            }

            // 위에서 인덱스[15] 중에서 초반에 값이 없는 곳은 null 일테고
            // 값이 있는 부분만 출력하기 위한 for loop
            for (int k = 0; k < result2.Length; k++)
            {
                resultText += result2[k];
            }

            // 최종 정리된 resultText는 다시 정리해서 workerName에 덮어쓰기
            workerName1.Text = resultText;
        }

        

        private void sortBtn2_Click(object sender, RoutedEventArgs e)
        {

            string str = workerName2.Text;
            string[] result = str.Split(new char[] { ',' });
            string[] result2 = new string[15];
            string resultText = "";



            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i].Trim() == "이상엽")
                {
                    result2[0] = "이상엽" + ", ";
                }
                else if (result[i].Trim() == "강범일")
                {
                    result2[1] = "강범일" + ", ";
                }
                else if (result[i].Trim() == "최광섭")
                {
                    result2[2] = "최광섭" + ", ";
                }
                else if (result[i].Trim() == "김진탁")
                {
                    result2[3] = "김진탁" + ", ";
                }
                else if (result[i].Trim() == "조광호")
                {
                    result2[4] = "조광호" + ", ";
                }
                else if (result[i].Trim() == "김태영")
                {
                    result2[5] = "김태영" + ", ";
                }
                else if (result[i].Trim() == "최현철")
                {
                    result2[6] = "최현철" + ", ";
                }
                else if (result[i].Trim() == "신재웅")
                {
                    result2[7] = "신재웅" + ", ";
                }
                else if (result[i].Trim() == "노진성")
                {
                    result2[8] = "노진성" + ", ";
                }
                else if (result[i].Trim() == "장다빈")
                {
                    result2[9] = "장다빈" + ", ";
                }
                else if (result[i].Trim() == "임성용")
                {
                    result2[10] = "임성용" + ", ";
                }
                else if (result[i].Trim() == "권용덕")
                {
                    result2[11] = "권용덕" + ", ";
                }
                else if (result[i].Trim() == "조용준")
                {
                    result2[12] = "조용준" + ", ";
                }
                else if (result[i].Trim() == "김민우")
                {
                    result2[13] = "김민우" + ", ";
                }
                else if (result[i].Trim() == "신지호")
                {
                    result2[14] = "신지호" + ", ";
                }
            }

            for (int k = 0; k < result2.Length; k++)
            {
                resultText += result2[k];
            }

            workerName2.Text = resultText;
        }

        private void sortBtn3_Click(object sender, RoutedEventArgs e)
        {

            string str = workerName3.Text;
            string[] result = str.Split(new char[] { ',' });
            string[] result2 = new string[15];
            string resultText = "";



            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i].Trim() == "이상엽")
                {
                    result2[0] = "이상엽" + ", ";
                }
                else if (result[i].Trim() == "강범일")
                {
                    result2[1] = "강범일" + ", ";
                }
                else if (result[i].Trim() == "최광섭")
                {
                    result2[2] = "최광섭" + ", ";
                }
                else if (result[i].Trim() == "김진탁")
                {
                    result2[3] = "김진탁" + ", ";
                }
                else if (result[i].Trim() == "조광호")
                {
                    result2[4] = "조광호" + ", ";
                }
                else if (result[i].Trim() == "김태영")
                {
                    result2[5] = "김태영" + ", ";
                }
                else if (result[i].Trim() == "최현철")
                {
                    result2[6] = "최현철" + ", ";
                }
                else if (result[i].Trim() == "신재웅")
                {
                    result2[7] = "신재웅" + ", ";
                }
                else if (result[i].Trim() == "노진성")
                {
                    result2[8] = "노진성" + ", ";
                }
                else if (result[i].Trim() == "장다빈")
                {
                    result2[9] = "장다빈" + ", ";
                }
                else if (result[i].Trim() == "임성용")
                {
                    result2[10] = "임성용" + ", ";
                }
                else if (result[i].Trim() == "권용덕")
                {
                    result2[11] = "권용덕" + ", ";
                }
                else if (result[i].Trim() == "조용준")
                {
                    result2[12] = "조용준" + ", ";
                }
                else if (result[i].Trim() == "김민우")
                {
                    result2[13] = "김민우" + ", ";
                }
                else if (result[i].Trim() == "신지호")
                {
                    result2[14] = "신지호" + ", ";
                }
            }

            for (int k = 0; k < result2.Length; k++)
            {
                resultText += result2[k];
            }

            workerName3.Text = resultText;
        }

        private void sortBtn4_Click(object sender, RoutedEventArgs e)
        {
            string str = workerName4.Text;
            string[] result = str.Split(new char[] { ',' });
            string[] result2 = new string[15];
            string resultText = "";

            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i].Trim() == "이상엽")
                {
                    result2[0] = "이상엽" + ", ";
                }
                else if (result[i].Trim() == "강범일")
                {
                    result2[1] = "강범일" + ", ";
                }
                else if (result[i].Trim() == "최광섭")
                {
                    result2[2] = "최광섭" + ", ";
                }
                else if (result[i].Trim() == "김진탁")
                {
                    result2[3] = "김진탁" + ", ";
                }
                else if (result[i].Trim() == "조광호")
                {
                    result2[4] = "조광호" + ", ";
                }
                else if (result[i].Trim() == "김태영")
                {
                    result2[5] = "김태영" + ", ";
                }
                else if (result[i].Trim() == "최현철")
                {
                    result2[6] = "최현철" + ", ";
                }
                else if (result[i].Trim() == "신재웅")
                {
                    result2[7] = "신재웅" + ", ";
                }
                else if (result[i].Trim() == "노진성")
                {
                    result2[8] = "노진성" + ", ";
                }
                else if (result[i].Trim() == "장다빈")
                {
                    result2[9] = "장다빈" + ", ";
                }
                else if (result[i].Trim() == "임성용")
                {
                    result2[10] = "임성용" + ", ";
                }
                else if (result[i].Trim() == "권용덕")
                {
                    result2[11] = "권용덕" + ", ";
                }
                else if (result[i].Trim() == "조용준")
                {
                    result2[12] = "조용준" + ", ";
                }
                else if (result[i].Trim() == "김민우")
                {
                    result2[13] = "김민우" + ", ";
                }
                else if (result[i].Trim() == "신지호")
                {
                    result2[14] = "신지호" + ", ";
                }
            }

            for (int k = 0; k < result2.Length; k++)
            {
                resultText += result2[k];
            }

            workerName4.Text = resultText;
        }


        private void sortBtn5_Click(object sender, RoutedEventArgs e)
        {
            string str = workerName5.Text;
            string[] result = str.Split(new char[] { ',' });
            string[] result2 = new string[15];
            string resultText = "";

            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i].Trim() == "이상엽")
                {
                    result2[0] = "이상엽" + ", ";
                }
                else if (result[i].Trim() == "강범일")
                {
                    result2[1] = "강범일" + ", ";
                }
                else if (result[i].Trim() == "최광섭")
                {
                    result2[2] = "최광섭" + ", ";
                }
                else if (result[i].Trim() == "김진탁")
                {
                    result2[3] = "김진탁" + ", ";
                }
                else if (result[i].Trim() == "조광호")
                {
                    result2[4] = "조광호" + ", ";
                }
                else if (result[i].Trim() == "김태영")
                {
                    result2[5] = "김태영" + ", ";
                }
                else if (result[i].Trim() == "최현철")
                {
                    result2[6] = "최현철" + ", ";
                }
                else if (result[i].Trim() == "신재웅")
                {
                    result2[7] = "신재웅" + ", ";
                }
                else if (result[i].Trim() == "노진성")
                {
                    result2[8] = "노진성" + ", ";
                }
                else if (result[i].Trim() == "장다빈")
                {
                    result2[9] = "장다빈" + ", ";
                }
                else if (result[i].Trim() == "임성용")
                {
                    result2[10] = "임성용" + ", ";
                }
                else if (result[i].Trim() == "권용덕")
                {
                    result2[11] = "권용덕" + ", ";
                }
                else if (result[i].Trim() == "조용준")
                {
                    result2[12] = "조용준" + ", ";
                }
                else if (result[i].Trim() == "김민우")
                {
                    result2[13] = "김민우" + ", ";
                }
                else if (result[i].Trim() == "신지호")
                {
                    result2[14] = "신지호" + ", ";
                }
            }

            for (int k = 0; k < result2.Length; k++)
            {
                resultText += result2[k];
            }

            workerName5.Text = resultText;
        }


        private void sortBtn6_Click(object sender, RoutedEventArgs e)
        {
            string str = workerName6.Text;
            string[] result = str.Split(new char[] { ',' });
            string[] result2 = new string[15];
            string resultText = "";

            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i].Trim() == "이상엽")
                {
                    result2[0] = "이상엽" + ", ";
                }
                else if (result[i].Trim() == "강범일")
                {
                    result2[1] = "강범일" + ", ";
                }
                else if (result[i].Trim() == "최광섭")
                {
                    result2[2] = "최광섭" + ", ";
                }
                else if (result[i].Trim() == "김진탁")
                {
                    result2[3] = "김진탁" + ", ";
                }
                else if (result[i].Trim() == "조광호")
                {
                    result2[4] = "조광호" + ", ";
                }
                else if (result[i].Trim() == "김태영")
                {
                    result2[5] = "김태영" + ", ";
                }
                else if (result[i].Trim() == "최현철")
                {
                    result2[6] = "최현철" + ", ";
                }
                else if (result[i].Trim() == "신재웅")
                {
                    result2[7] = "신재웅" + ", ";
                }
                else if (result[i].Trim() == "노진성")
                {
                    result2[8] = "노진성" + ", ";
                }
                else if (result[i].Trim() == "장다빈")
                {
                    result2[9] = "장다빈" + ", ";
                }
                else if (result[i].Trim() == "임성용")
                {
                    result2[10] = "임성용" + ", ";
                }
                else if (result[i].Trim() == "권용덕")
                {
                    result2[11] = "권용덕" + ", ";
                }
                else if (result[i].Trim() == "조용준")
                {
                    result2[12] = "조용준" + ", ";
                }
                else if (result[i].Trim() == "김민우")
                {
                    result2[13] = "김민우" + ", ";
                }
                else if (result[i].Trim() == "신지호")
                {
                    result2[14] = "신지호" + ", ";
                }
            }

            for (int k = 0; k < result2.Length; k++)
            {
                resultText += result2[k];
            }

            workerName6.Text = resultText;
        }


        private void sortBtn7_Click(object sender, RoutedEventArgs e)
        {
            string str = workerName7.Text;
            string[] result = str.Split(new char[] { ',' });
            string[] result2 = new string[15];
            string resultText = "";

            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i].Trim() == "이상엽")
                {
                    result2[0] = "이상엽" + ", ";
                }
                else if (result[i].Trim() == "강범일")
                {
                    result2[1] = "강범일" + ", ";
                }
                else if (result[i].Trim() == "최광섭")
                {
                    result2[2] = "최광섭" + ", ";
                }
                else if (result[i].Trim() == "김진탁")
                {
                    result2[3] = "김진탁" + ", ";
                }
                else if (result[i].Trim() == "조광호")
                {
                    result2[4] = "조광호" + ", ";
                }
                else if (result[i].Trim() == "김태영")
                {
                    result2[5] = "김태영" + ", ";
                }
                else if (result[i].Trim() == "최현철")
                {
                    result2[6] = "최현철" + ", ";
                }
                else if (result[i].Trim() == "신재웅")
                {
                    result2[7] = "신재웅" + ", ";
                }
                else if (result[i].Trim() == "노진성")
                {
                    result2[8] = "노진성" + ", ";
                }
                else if (result[i].Trim() == "장다빈")
                {
                    result2[9] = "장다빈" + ", ";
                }
                else if (result[i].Trim() == "임성용")
                {
                    result2[10] = "임성용" + ", ";
                }
                else if (result[i].Trim() == "권용덕")
                {
                    result2[11] = "권용덕" + ", ";
                }
                else if (result[i].Trim() == "조용준")
                {
                    result2[12] = "조용준" + ", ";
                }
                else if (result[i].Trim() == "김민우")
                {
                    result2[13] = "김민우" + ", ";
                }
                else if (result[i].Trim() == "신지호")
                {
                    result2[14] = "신지호" + ", ";
                }
            }

            for (int k = 0; k < result2.Length; k++)
            {
                resultText += result2[k];
            }

            workerName7.Text = resultText;
        }


        private void sortBtn8_Click(object sender, RoutedEventArgs e)
        {
            string str = workerName8.Text;
            string[] result = str.Split(new char[] { ',' });
            string[] result2 = new string[15];
            string resultText = "";

            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i].Trim() == "이상엽")
                {
                    result2[0] = "이상엽" + ", ";
                }
                else if (result[i].Trim() == "강범일")
                {
                    result2[1] = "강범일" + ", ";
                }
                else if (result[i].Trim() == "최광섭")
                {
                    result2[2] = "최광섭" + ", ";
                }
                else if (result[i].Trim() == "김진탁")
                {
                    result2[3] = "김진탁" + ", ";
                }
                else if (result[i].Trim() == "조광호")
                {
                    result2[4] = "조광호" + ", ";
                }
                else if (result[i].Trim() == "김태영")
                {
                    result2[5] = "김태영" + ", ";
                }
                else if (result[i].Trim() == "최현철")
                {
                    result2[6] = "최현철" + ", ";
                }
                else if (result[i].Trim() == "신재웅")
                {
                    result2[7] = "신재웅" + ", ";
                }
                else if (result[i].Trim() == "노진성")
                {
                    result2[8] = "노진성" + ", ";
                }
                else if (result[i].Trim() == "장다빈")
                {
                    result2[9] = "장다빈" + ", ";
                }
                else if (result[i].Trim() == "임성용")
                {
                    result2[10] = "임성용" + ", ";
                }
                else if (result[i].Trim() == "권용덕")
                {
                    result2[11] = "권용덕" + ", ";
                }
                else if (result[i].Trim() == "조용준")
                {
                    result2[12] = "조용준" + ", ";
                }
                else if (result[i].Trim() == "김민우")
                {
                    result2[13] = "김민우" + ", ";
                }
                else if (result[i].Trim() == "신지호")
                {
                    result2[14] = "신지호" + ", ";
                }
            }

            for (int k = 0; k < result2.Length; k++)
            {
                resultText += result2[k];
            }

            workerName8.Text = resultText;
        }


        private void sortBtn9_Click(object sender, RoutedEventArgs e)
        {
            string str = workerName9.Text;
            string[] result = str.Split(new char[] { ',' });
            string[] result2 = new string[15];
            string resultText = "";

            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i].Trim() == "이상엽")
                {
                    result2[0] = "이상엽" + ", ";
                }
                else if (result[i].Trim() == "강범일")
                {
                    result2[1] = "강범일" + ", ";
                }
                else if (result[i].Trim() == "최광섭")
                {
                    result2[2] = "최광섭" + ", ";
                }
                else if (result[i].Trim() == "김진탁")
                {
                    result2[3] = "김진탁" + ", ";
                }
                else if (result[i].Trim() == "조광호")
                {
                    result2[4] = "조광호" + ", ";
                }
                else if (result[i].Trim() == "김태영")
                {
                    result2[5] = "김태영" + ", ";
                }
                else if (result[i].Trim() == "최현철")
                {
                    result2[6] = "최현철" + ", ";
                }
                else if (result[i].Trim() == "신재웅")
                {
                    result2[7] = "신재웅" + ", ";
                }
                else if (result[i].Trim() == "노진성")
                {
                    result2[8] = "노진성" + ", ";
                }
                else if (result[i].Trim() == "장다빈")
                {
                    result2[9] = "장다빈" + ", ";
                }
                else if (result[i].Trim() == "임성용")
                {
                    result2[10] = "임성용" + ", ";
                }
                else if (result[i].Trim() == "권용덕")
                {
                    result2[11] = "권용덕" + ", ";
                }
                else if (result[i].Trim() == "조용준")
                {
                    result2[12] = "조용준" + ", ";
                }
                else if (result[i].Trim() == "김민우")
                {
                    result2[13] = "김민우" + ", ";
                }
                else if (result[i].Trim() == "신지호")
                {
                    result2[14] = "신지호" + ", ";
                }
            }

            for (int k = 0; k < result2.Length; k++)
            {
                resultText += result2[k];
            }

            workerName9.Text = resultText;
        }



        private void sortBtn10_Click(object sender, RoutedEventArgs e)
        {
            string str = workerName10.Text;
            string[] result = str.Split(new char[] { ',' });
            string[] result2 = new string[15];
            string resultText = "";

            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i].Trim() == "이상엽")
                {
                    result2[0] = "이상엽" + ", ";
                }
                else if (result[i].Trim() == "강범일")
                {
                    result2[1] = "강범일" + ", ";
                }
                else if (result[i].Trim() == "최광섭")
                {
                    result2[2] = "최광섭" + ", ";
                }
                else if (result[i].Trim() == "김진탁")
                {
                    result2[3] = "김진탁" + ", ";
                }
                else if (result[i].Trim() == "조광호")
                {
                    result2[4] = "조광호" + ", ";
                }
                else if (result[i].Trim() == "김태영")
                {
                    result2[5] = "김태영" + ", ";
                }
                else if (result[i].Trim() == "최현철")
                {
                    result2[6] = "최현철" + ", ";
                }
                else if (result[i].Trim() == "신재웅")
                {
                    result2[7] = "신재웅" + ", ";
                }
                else if (result[i].Trim() == "노진성")
                {
                    result2[8] = "노진성" + ", ";
                }
                else if (result[i].Trim() == "장다빈")
                {
                    result2[9] = "장다빈" + ", ";
                }
                else if (result[i].Trim() == "임성용")
                {
                    result2[10] = "임성용" + ", ";
                }
                else if (result[i].Trim() == "권용덕")
                {
                    result2[11] = "권용덕" + ", ";
                }
                else if (result[i].Trim() == "조용준")
                {
                    result2[12] = "조용준" + ", ";
                }
                else if (result[i].Trim() == "김민우")
                {
                    result2[13] = "김민우" + ", ";
                }
                else if (result[i].Trim() == "신지호")
                {
                    result2[14] = "신지호" + ", ";
                }
            }

            for (int k = 0; k < result2.Length; k++)
            {
                resultText += result2[k];
            }

            workerName10.Text = resultText;
        }


        private void recordBtn1_Click(object sender, RoutedEventArgs e)
        {
            // 기록버튼을 누르면
            // 원래 카톡에 쓰는 방식대로 부족한 수식어 부분을 채워넣고

            var sumTime1 = "■ " + time1.Text + "시 ";
            var sumCharge1 = charge1.Text + "님 ";
            var sumLine1 = line1.Text + "L ";
            var sumFloor1 = floor1.Text + "층 ";
            var sumBay1 = bay1.Text + "베이 ";
            var sumEquipName1 = equipName1.Text + " ";
            var sumEquipCode1 = equipCode1.Text + " ";
            var sumEquipNum1 = equipNum1.Text + "호기 ";
            var sumChamber1 = chamber1.Text + "챔버\r\n / ";

            workSummaryText.Text += sumTime1;
            workSummaryText.Text += sumCharge1;
            workSummaryText.Text += sumLine1;
            workSummaryText.Text += sumFloor1;
            workSummaryText.Text += sumBay1;
            workSummaryText.Text += sumEquipName1;
            workSummaryText.Text += sumEquipCode1;
            workSummaryText.Text += sumEquipNum1;
            workSummaryText.Text += sumChamber1;

            // 정렬까지 끝난 작업자 부분과 합쳐서 우측 최종 작업 요약 창에 기록함. \r\n은 한줄 띄우기
            workSummaryText.Text += workerName1.Text + "\r\n\r\n";
        }

        private void recordBtn2_Click(object sender, RoutedEventArgs e)
        {
            var sumTime2 = "■ " + time2.Text + "시 ";
            var sumCharge2 = charge2.Text + "님 ";
            var sumLine2 = line2.Text + "L ";
            var sumFloor2 = floor2.Text + "층 ";
            var sumBay2 = bay2.Text + "베이 ";
            var sumEquipName2 = equipName2.Text + " ";
            var sumEquipCode2 = equipCode2.Text + " ";
            var sumEquipNum2 = equipNum2.Text + "호기 ";
            var sumChamber2 = chamber2.Text + "챔버\r\n / ";

            workSummaryText.Text += sumTime2;
            workSummaryText.Text += sumCharge2;
            workSummaryText.Text += sumLine2;
            workSummaryText.Text += sumFloor2;
            workSummaryText.Text += sumBay2;
            workSummaryText.Text += sumEquipName2;
            workSummaryText.Text += sumEquipCode2;
            workSummaryText.Text += sumEquipNum2;
            workSummaryText.Text += sumChamber2;

            workSummaryText.Text += workerName2.Text + "\r\n\r\n";
        }

        private void recordBtn3_Click(object sender, RoutedEventArgs e)
        {
            var sumTime3 = "■ " + time3.Text + "시 ";
            var sumCharge3 = charge3.Text + "님 ";
            var sumLine3 = line3.Text + "L ";
            var sumFloor3 = floor3.Text + "층 ";
            var sumBay3 = bay3.Text + "베이 ";
            var sumEquipName3 = equipName3.Text + " ";
            var sumEquipCode3 = equipCode3.Text + " ";
            var sumEquipNum3 = equipNum3.Text + "호기 ";
            var sumChamber3 = chamber3.Text + "챔버\r\n / ";

            workSummaryText.Text += sumTime3;
            workSummaryText.Text += sumCharge3;
            workSummaryText.Text += sumLine3;
            workSummaryText.Text += sumFloor3;
            workSummaryText.Text += sumBay3;
            workSummaryText.Text += sumEquipName3;
            workSummaryText.Text += sumEquipCode3;
            workSummaryText.Text += sumEquipNum3;
            workSummaryText.Text += sumChamber3;

            workSummaryText.Text += workerName3.Text + "\r\n\r\n";
        }

        private void recordBtn4_Click(object sender, RoutedEventArgs e)
        {
            var sumTime4 = "■ " + time4.Text +  "시 ";
            var sumCharge4 = charge4.Text + "님 ";
            var sumLine4 = line4.Text + "L ";
            var sumFloor4 = floor4.Text + "층 ";
            var sumBay4 = bay4.Text + "베이 ";
            var sumEquipName4 = equipName4.Text + " ";
            var sumEquipCode4 = equipCode4.Text + " ";
            var sumEquipNum4 = equipNum4.Text + "호기 ";
            var sumChamber4 = chamber4.Text + "챔버\r\n / ";
            
            workSummaryText.Text += sumTime4;
            workSummaryText.Text += sumCharge4;
            workSummaryText.Text += sumLine4;
            workSummaryText.Text += sumFloor4;
            workSummaryText.Text += sumBay4;
            workSummaryText.Text += sumEquipName4;
            workSummaryText.Text += sumEquipCode4;
            workSummaryText.Text += sumEquipNum4;
            workSummaryText.Text += sumChamber4;

            workSummaryText.Text += workerName4.Text + "\r\n\r\n";
        }


        private void recordBtn5_Click(object sender, RoutedEventArgs e)
        {
            var sumTime5 = "■ " + time5.Text + "시 ";
            var sumCharge5 = charge5.Text + "님 ";
            var sumLine5 = line5.Text + "L ";
            var sumFloor5 = floor5.Text + "층 ";
            var sumBay5 = bay5.Text + "베이 ";
            var sumEquipName5 = equipName5.Text + " ";
            var sumEquipCode5 = equipCode5.Text + " ";
            var sumEquipNum5 = equipNum5.Text + "호기 ";
            var sumChamber5 = chamber5.Text + "챔버\r\n / ";

            workSummaryText.Text += sumTime5;
            workSummaryText.Text += sumCharge5;
            workSummaryText.Text += sumLine5;
            workSummaryText.Text += sumFloor5;
            workSummaryText.Text += sumBay5;
            workSummaryText.Text += sumEquipName5;
            workSummaryText.Text += sumEquipCode5;
            workSummaryText.Text += sumEquipNum5;
            workSummaryText.Text += sumChamber5;

            workSummaryText.Text += workerName5.Text + "\r\n\r\n";
        }


        private void recordBtn6_Click(object sender, RoutedEventArgs e)
        {
            var sumTime6 = "■ " + time6.Text + "시 ";
            var sumCharge6 = charge6.Text + "님 ";
            var sumLine6 = line6.Text + "L ";
            var sumFloor6 = floor6.Text + "층 ";
            var sumBay6 = bay6.Text + "베이 ";
            var sumEquipName6 = equipName6.Text + " ";
            var sumEquipCode6 = equipCode6.Text + " ";
            var sumEquipNum6 = equipNum6.Text + "호기 ";
            var sumChamber6 = chamber6.Text + "챔버\r\n / ";

            workSummaryText.Text += sumTime6;
            workSummaryText.Text += sumCharge6;
            workSummaryText.Text += sumLine6;
            workSummaryText.Text += sumFloor6;
            workSummaryText.Text += sumBay6;
            workSummaryText.Text += sumEquipName6;
            workSummaryText.Text += sumEquipCode6;
            workSummaryText.Text += sumEquipNum6;
            workSummaryText.Text += sumChamber6;

            workSummaryText.Text += workerName6.Text + "\r\n\r\n";
        }


        private void recordBtn7_Click(object sender, RoutedEventArgs e)
        {
            var sumTime7 = "■ " + time7.Text + "시 ";
            var sumCharge7 = charge7.Text + "님 ";
            var sumLine7 = line7.Text + "L ";
            var sumFloor7 = floor7.Text + "층 ";
            var sumBay7 = bay7.Text + "베이 ";
            var sumEquipName7 = equipName7.Text + " ";
            var sumEquipCode7 = equipCode7.Text + " ";
            var sumEquipNum7 = equipNum7.Text + "호기 ";
            var sumChamber7 = chamber7.Text + "챔버\r\n / ";

            workSummaryText.Text += sumTime7;
            workSummaryText.Text += sumCharge7;
            workSummaryText.Text += sumLine7;
            workSummaryText.Text += sumFloor7;
            workSummaryText.Text += sumBay7;
            workSummaryText.Text += sumEquipName7;
            workSummaryText.Text += sumEquipCode7;
            workSummaryText.Text += sumEquipNum7;
            workSummaryText.Text += sumChamber7;

            workSummaryText.Text += workerName7.Text + "\r\n\r\n";
        }


        private void recordBtn8_Click(object sender, RoutedEventArgs e)
        {
            var sumTime8 = "■ " + time8.Text + "시 ";
            var sumCharge8 = charge8.Text + "님 ";
            var sumLine8 = line8.Text + "L ";
            var sumFloor8 = floor8.Text + "층 ";
            var sumBay8 = bay8.Text + "베이 ";
            var sumEquipName8 = equipName8.Text + " ";
            var sumEquipCode8 = equipCode8.Text + " ";
            var sumEquipNum8 = equipNum8.Text + "호기 ";
            var sumChamber8 = chamber8.Text + "챔버\r\n / ";

            workSummaryText.Text += sumTime8;
            workSummaryText.Text += sumCharge8;
            workSummaryText.Text += sumLine8;
            workSummaryText.Text += sumFloor8;
            workSummaryText.Text += sumBay8;
            workSummaryText.Text += sumEquipName8;
            workSummaryText.Text += sumEquipCode8;
            workSummaryText.Text += sumEquipNum8;
            workSummaryText.Text += sumChamber8;

            workSummaryText.Text += workerName8.Text + "\r\n\r\n";
        }


        private void recordBtn9_Click(object sender, RoutedEventArgs e)
        {
            var sumTime9 = "■ " + time9.Text + "시 ";
            var sumCharge9 = charge9.Text + "님 ";
            var sumLine9 = line9.Text + "L ";
            var sumFloor9 = floor9.Text + "층 ";
            var sumBay9 = bay9.Text + "베이 ";
            var sumEquipName9 = equipName9.Text + " ";
            var sumEquipCode9 = equipCode9.Text + " ";
            var sumEquipNum9 = equipNum9.Text + "호기 ";
            var sumChamber9 = chamber9.Text + "챔버\r\n / ";

            workSummaryText.Text += sumTime9;
            workSummaryText.Text += sumCharge9;
            workSummaryText.Text += sumLine9;
            workSummaryText.Text += sumFloor9;
            workSummaryText.Text += sumBay9;
            workSummaryText.Text += sumEquipName9;
            workSummaryText.Text += sumEquipCode9;
            workSummaryText.Text += sumEquipNum9;
            workSummaryText.Text += sumChamber9;

            workSummaryText.Text += workerName9.Text + "\r\n\r\n";
        }

        private void recordBtn10_Click(object sender, RoutedEventArgs e)
        {
            var sumTime10 = "■ " + time10.Text + "시 ";
            var sumCharge10 = charge10.Text + "님 ";
            var sumLine10 = line10.Text + "L ";
            var sumFloor10 = floor10.Text + "층 ";
            var sumBay10 = bay10.Text + "베이 ";
            var sumEquipName10 = equipName10.Text + " ";
            var sumEquipCode10 = equipCode10.Text + " ";
            var sumEquipNum10 = equipNum10.Text + "호기 ";
            var sumChamber10 = chamber10.Text + "챔버\r\n / ";

            workSummaryText.Text += sumTime10;
            workSummaryText.Text += sumCharge10;
            workSummaryText.Text += sumLine10;
            workSummaryText.Text += sumFloor10;
            workSummaryText.Text += sumBay10;
            workSummaryText.Text += sumEquipName10;
            workSummaryText.Text += sumEquipCode10;
            workSummaryText.Text += sumEquipNum10;
            workSummaryText.Text += sumChamber10;

            workSummaryText.Text += workerName10.Text + "\r\n\r\n";
        }

        private void sumDel_Click(object sender, RoutedEventArgs e)
        {
            workSummaryText.Clear();
        }
    }
}