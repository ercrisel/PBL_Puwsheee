using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_Puwsheee
{
    class Fade
    {
        public static void fadeInEffect(Form form, Timer timer)
        {
            if (form.Opacity == 1)
            {
                timer.Stop();
            }
            form.Opacity += .2;
        }

        public static void fadeOutEffect(Form form)
        {
            if (form.Opacity <= 0)
            {
                form.Close();
            }
            form.Opacity -= .2;
        }

        public static void exitFade(Form form)
        {
            if (form.Opacity <= 0)
            {
                Application.Exit();
            }
            form.Opacity -= .2;
        }

        public static void closeFade(Form form)
        {
            if (form.Opacity <= 0)
            {
                form.Close();
            }
            form.Opacity -= .2;
        }

        public static void fadeInModalBg(Form form, Timer timer)
        {
            if (form.Opacity == .50)
            {
                timer.Stop();
                form.Show();
            }
            form.Opacity += .2;
        }

        public static void fadeInModalForm(Form form, Timer timer)
        {
            if (form.Opacity == 1)
            {
                timer.Stop();
                form.ShowDialog();
            }
            form.Opacity += .2;
        }
    }
}
