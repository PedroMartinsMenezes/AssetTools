namespace AssetTool
{
    [JsonAsset("LightWeightInstanceFactory")]
    public class ULightWeightInstanceFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}