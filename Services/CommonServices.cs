using Abp;
using lifedashboard.Enums;

namespace lifedashboard.Services
{
    public class CommonServices
    {
        public static string ShowAlert(Alerts obj, string message)
        {
            string alertDiv = null;
            switch (obj)
            {
                case Alerts.Success:
                    alertDiv = "<div class='alert alert-success alert-dismissable' id='alert'><button type='submit' class='close' data-dismiss='alert'>×</button><strong> Success!</ strong > " + message + "</div>";
                    break;
                case Alerts.Danger:
                    alertDiv = "<div class='alert alert-danger alert-dismissible' id='alert'><button type='Submit' class='close' data-dismiss='alert'>×</button><strong> Error!</ strong > " + message + "</a>.</div>";
                    break;
                case Alerts.Info:
                    alertDiv = "<div class='alert alert-dismissible alert-info'> <button type = 'Submit' class='btn-close' data-bs-dismiss='alert'></button>  <strong>Heads up!</strong>" + message + "</div>";
                    break;
                case Alerts.Warning:
                    alertDiv =$"<div class='alert alert-dismissible alert-warning'><button type='submit' class='btn-close' data-bs-dismiss='alert'></button><h4 class='alert-heading'>Warning!</h4><p class='mb-0'>{message}</p></div>";
                    break;
            }
            return alertDiv.Replace("\"", string.Empty).Trim(); ;
        }

        
    }
}
