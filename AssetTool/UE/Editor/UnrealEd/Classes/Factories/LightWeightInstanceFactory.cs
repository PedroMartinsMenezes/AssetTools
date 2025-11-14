namespace AssetTool
{
    [JsonAsset("LightWeightInstanceFactory")]
    public class ULightWeightInstanceFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}