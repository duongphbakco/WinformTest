using WinformTester.Models;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace WinformTester
{
    public partial class MainForm : Form
    {
        private ConcurrentBag<Person> People = new ConcurrentBag<Person>();

        public MainForm()
        {
            InitializeComponent();
        }

        public void SetLabel(string data)
        {
            lbTime.Text = data;
        }

        private bool InitPeople(int quantity)
        {
            var result = Parallel.For(0, quantity, (i, state) =>
            {
                People.Add(new Person(i));
            });
            return result.IsCompleted;
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            UpperPeopleParallel();
        }

        private void UpperPeople()
        {
            var sw = Stopwatch.StartNew();
            foreach (var person in People)
            {
                person.ToUpperString();
            }
            sw.Stop();
            lbTime.Text = $"Time: {sw.ElapsedMilliseconds} ms";
            dtgMain.Refresh();
        }

        private void UpperPeopleParallel()
        {
            pb1.Value = 0;
            Task.Factory.StartNew(() => {
                var sw = Stopwatch.StartNew();
                var result = Parallel.ForEach(People, person =>
                {
                    person.ToUpperString();
                });

                if (result.IsCompleted)
                {
                    sw.Stop();
                    this.Invoke(new MethodInvoker(delegate () {
                        lbTime.Text = $"Time: {sw.ElapsedMilliseconds} ms";
                        dtgMain.Refresh();
                        pb1.Value = 100;
                    }));
                }
            });
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            var sw = Stopwatch.StartNew();
            var result = Parallel.ForEach(People, person =>
            {
                person.ToLowerString();
            });

            if (result.IsCompleted)
            {
                sw.Stop();
                lbTime.Text = $"Time: {sw.ElapsedMilliseconds} ms";
                dtgMain.Refresh();
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != null)
            {
                var sw = Stopwatch.StartNew();
                var q = int.Parse(txtQuantity.Text);
                bool completed = InitPeople(q);
                var ordered = People.OrderBy(x => x.Id).ToList();
                dtgMain.DataSource = ordered;
                sw.Stop();
                lbTime.Text = $"Time: {sw.ElapsedMilliseconds} ms";
            }
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            UpperPeople();
        }
    }
}