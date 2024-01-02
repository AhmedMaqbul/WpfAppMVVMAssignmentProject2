using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMVVMAssignmentProject2.ViewModel;

namespace WpfAppMVVMAssignmentProject2.Commands
{
    public class AddCommand : BaseCommand
    {
        private readonly MainWindowViewModel addContext;
        public AddCommand(MainWindowViewModel addContext)
        {
            this.addContext = addContext;
        }

        public override bool CanExecute(object parameter)
        {
            return addContext.CanAdd();
        }

        public override void Execute(object parameter)
        {
            addContext.Add();
        }
    }
}
