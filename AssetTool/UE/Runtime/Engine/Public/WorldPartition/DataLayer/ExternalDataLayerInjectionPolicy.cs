namespace AssetTool
{
    [JsonAsset("ExternalDataLayerInjectionPolicy")]
    public class UExternalDataLayerInjectionPolicy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}