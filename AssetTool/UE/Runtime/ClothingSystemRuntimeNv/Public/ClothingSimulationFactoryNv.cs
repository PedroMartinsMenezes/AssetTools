namespace AssetTool
{
    [JsonAsset("ClothingSimulationFactoryNv")]
    public class UClothingSimulationFactoryNv : UClothingSimulationFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}