namespace AssetTool
{
    [JsonAsset("LightWeightInstanceFactory")]
    public class ULightWeightInstanceFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}