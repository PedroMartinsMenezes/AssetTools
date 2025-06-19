namespace AssetTool
{
    [JsonAsset("CookGlobalShadersCommandlet")]
    public class UCookGlobalShadersCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CookGlobalShadersDeviceHelperBase")]
    public class UCookGlobalShadersDeviceHelperBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CookGlobalShadersDeviceHelperStaged")]
    public class UCookGlobalShadersDeviceHelperStaged : UCookGlobalShadersDeviceHelperBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}