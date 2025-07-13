namespace AssetTool
{
    [JsonAsset("ClothingInteractor")]
    public class UClothingInteractor : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ClothingSimulationInteractor")]
    public class UClothingSimulationInteractor : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}