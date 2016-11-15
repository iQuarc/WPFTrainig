using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using WPF_Training2.Messages;

namespace WPF_Training2
{
    public class EmployeViewModel : Screen
    {
        private readonly IEventAggregator eventAggregator;
        public EmployeViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            Employee = new Employee();
        }
        public Employee Employee { get; set; }

        public bool CanClose()
        {
            return false;
        }

        protected override void OnViewLoaded(object view)
        {
            eventAggregator.PublishOnUIThreadAsync(new StatusMessage("Employee module loaded"));
            base.OnViewLoaded(view);
        }

        public override void CanClose(Action<bool> callback)
        {
            callback(true);
        }
    }
}
