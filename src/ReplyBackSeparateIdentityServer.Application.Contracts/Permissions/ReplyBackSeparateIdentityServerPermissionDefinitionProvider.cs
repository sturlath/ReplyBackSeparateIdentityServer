using ReplyBackSeparateIdentityServer.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ReplyBackSeparateIdentityServer.Permissions;

public class ReplyBackSeparateIdentityServerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ReplyBackSeparateIdentityServerPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ReplyBackSeparateIdentityServerPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ReplyBackSeparateIdentityServerResource>(name);
    }
}
