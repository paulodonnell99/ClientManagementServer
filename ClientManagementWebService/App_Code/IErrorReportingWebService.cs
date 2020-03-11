using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract]
public interface IErrorReportingWebService
{
    [OperationContract]
    bool ReportError(ClientErrorReport errorReport);
}

[DataContract]
public class ClientErrorReport
{
    DateTime dateReported;
    int clientId;
    string errorLog;

    [DataMember]
    public DateTime DateReported
    {
        get {
            return dateReported;
        }

        set {
            dateReported = value;
        }
    }

    [DataMember]
    public int ClientId
    {
        get {
            return clientId;
        }

        set {
            clientId = value;
        }
    }

    [DataMember]
    public string ErrorLog
    {
        get {
            return errorLog;
        }

        set {
            errorLog = value;
        }
    }
}
