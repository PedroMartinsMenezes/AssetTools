namespace AssetTool
{
    [JsonAsset("ExternalDataLayerInjectionPolicy")]
    public class UExternalDataLayerInjectionPolicy : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}