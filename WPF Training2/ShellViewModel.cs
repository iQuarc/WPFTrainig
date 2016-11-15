using Caliburn.Micro;
using WPF_Training2.Messages;

namespace WPF_Training2
{
    public class ShellViewModel : Conductor<object>, IShell, IHandle<StatusMessage>
    {
        private readonly EmployeViewModel employeViewModel;
        private readonly IEventAggregator eventAggregator;
        private string message;

        public ShellViewModel(EmployeViewModel employeViewModel, IEventAggregator eventAggregator)
        {
            this.employeViewModel = employeViewModel;
            this.eventAggregator = eventAggregator;
            this.eventAggregator.Subscribe(this);
        }

        public void OpenEmployeeModule()
        {
            this.ActivateItem(employeViewModel);
        }

        public string Message
        {
            get { return message; }
            set
            {
                if (value == message) return;
                message = value;
                NotifyOfPropertyChange();
            }
        }

        public void Handle(StatusMessage message)
        {
            this.Message = message.Message;
        }
    }
}