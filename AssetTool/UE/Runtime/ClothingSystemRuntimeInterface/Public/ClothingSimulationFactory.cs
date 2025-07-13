namespace AssetTool
{
    [JsonAsset("ClothingSimulationFactory")]
    public class UClothingSimulationFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}