<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        //Initialse Database
        System.Data.Entity.Database.SetInitializer(new ClientManagement.Data.SeedClientDatabase());

        //Configure Autofac container
        var container = Binder.Register(); 
        Autofac.Integration.Wcf.AutofacHostFactory.Container = container;
    }
          
</script>
