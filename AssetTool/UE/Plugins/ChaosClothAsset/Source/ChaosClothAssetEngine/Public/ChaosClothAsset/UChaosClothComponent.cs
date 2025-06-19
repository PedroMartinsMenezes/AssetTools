namespace AssetTool
{
    [JsonAsset("ChaosClothComponent")]
    public class UChaosClothComponent : USkinnedMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}