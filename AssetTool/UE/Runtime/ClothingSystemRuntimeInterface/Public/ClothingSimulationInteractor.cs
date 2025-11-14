namespace AssetTool
{
    [JsonAsset("ClothingInteractor")]
    public class UClothingInteractor : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ClothingSimulationInteractor")]
    public class UClothingSimulationInteractor : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}