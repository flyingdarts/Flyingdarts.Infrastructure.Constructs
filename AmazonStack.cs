
namespace Flyingdarts.Infrastructure;

public class AmazonStack : Stack
{

    public AmazonStack(Construct scope, IStackProps props, string[] repositories) : base(scope, "Flyingdarts-Stack", props)
    {
        new BackendConstruct(this, "Backend", repositories.Where(x=>!x.Contains("Signalling")).ToArray());
        //new AmplifyConstruct(this, "Frontend");
        new AuthConstruct(this, "OIDC", repositories);
    }
}
