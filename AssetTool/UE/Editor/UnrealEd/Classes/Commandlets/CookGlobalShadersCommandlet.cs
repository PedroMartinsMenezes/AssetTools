namespace AssetTool
{
    [JsonAsset("CookGlobalShadersCommandlet")]
    public class UCookGlobalShadersCommandlet : UCommandlet
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CookGlobalShadersDeviceHelperBase")]
    public class UCookGlobalShadersDeviceHelperBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CookGlobalShadersDeviceHelperStaged")]
    public class UCookGlobalShadersDeviceHelperStaged : UCookGlobalShadersDeviceHelperBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}