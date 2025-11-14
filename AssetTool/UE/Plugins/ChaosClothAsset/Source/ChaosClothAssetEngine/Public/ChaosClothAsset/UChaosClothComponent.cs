namespace AssetTool
{
    [JsonAsset("ChaosClothComponent")]
    public class UChaosClothComponent : USkinnedMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}