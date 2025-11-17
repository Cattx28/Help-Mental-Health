using Apresentação;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeuNamespace
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Mostrar a splash screen
            var splash = new frmSplashScreen();
            splash.Show();

            // 2. Carregar recursos em background
            Task.Run(() => InitializeApplication(splash));

            // 3. Manter a aplicação rodando (ÚNICO Application.Run)
            Application.Run();
        }

        static void InitializeApplication(frmSplashScreen splash)
        {
            try
            {
                // Simular estágios de carregamento (substitua pelo seu código real)
                UpdateProgress(splash, 10);
                Thread.Sleep(500);

                UpdateProgress(splash, 40);
                Thread.Sleep(800);

                UpdateProgress(splash, 70);
                Thread.Sleep(600);

                UpdateProgress(splash, 100);
                Thread.Sleep(300);

                // 4. Criar e gerenciar os formulários na thread UI
                splash.Invoke((MethodInvoker)delegate
                {
                    // Fechar a splash screen
                    splash.Close();

                    // Criar o formulário de login
                    var login = new frmLogin();

                    // Configurar o comportamento quando o login fechar
                    login.FormClosed += (s, e) =>
                    {
                        if (login.DialogResult == DialogResult.OK)
                        {
                            /*// Login bem-sucedido - mostrar formulário principal
                            var mainForm = new frmInicial();

                            // Configurar para encerrar aplicação quando o mainForm fechar
                            mainForm.FormClosed += (s, e) => Application.Exit();

                            mainForm.Show();*/
                        }
                        else
                        {
                            // Usuário cancelou o login - encerrar aplicação
                            Application.Exit();
                        }
                    };

                    // Mostrar o formulário de login
                    login.Show();
                });
            }
            catch (Exception ex)
            {
                // Tratar erros durante a inicialização
                splash.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show($"Erro durante a inicialização:\n{ex.Message}",
                                  "Erro",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    Application.Exit();
                });
            }
        }

        static void UpdateProgress(Form splash, int progress)
        {
            if (splash.IsDisposed) return;

            splash.Invoke((MethodInvoker)delegate
            {
                if (!splash.IsDisposed && splash is frmSplashScreen splashForm)
                {
                    splashForm.UpdateProgress(progress);
                }
            });
        }
    }
}