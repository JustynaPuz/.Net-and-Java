namespace GUI
{
    internal class FormManager : ApplicationContext
    {
        private void onFormClosed(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                ExitThread();
            }
        }

        public T createForm<T>() where T : Form, new()
        {
            var ret = new T();
            ret.FormClosed += onFormClosed;
            return ret;
        }

        private static Lazy<FormManager> _current = new Lazy<FormManager>();
        public static FormManager Current => _current.Value;

        public FormManager()
        {
            var f1 = createForm<Main>();
            f1.Show();
        }
    }
}
