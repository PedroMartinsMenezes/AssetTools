namespace AssetTool
{
    [JsonAsset("ChaosClothComponent")]
    public class UChaosClothComponent : USkinnedMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}