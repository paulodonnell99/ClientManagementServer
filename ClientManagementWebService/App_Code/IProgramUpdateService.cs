using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProgramUpdateService" in both code and config file together.
[ServiceContract]
public interface IProgramUpdateService
{
    [OperationContract]
    UpdateInfo CheckForUpdates(VersionInfo versionInfo);
}

[DataContract]
public class VersionInfo
{
    [DataMember]
    public int ClientId { get; set; }

    [DataMember]
    public int VersionMajor { get; set; }

    [DataMember]
    public int VersionMinor { get; set; }

    [DataMember]
    public int VersionDatabase { get; set; }

    [DataMember]
    public int BuildNo { get; set; }
}

[DataContract]
public class UpdateInfo
{
    [DataMember]
    public string ReleaseVersion { get; set; }

    [DataMember]
    public bool ReleaseAvailable { get; set; }

    [DataMember]
    public string DownloadURL { get; set; }
}

