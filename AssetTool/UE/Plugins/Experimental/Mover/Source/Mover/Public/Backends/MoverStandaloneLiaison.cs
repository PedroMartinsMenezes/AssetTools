namespace AssetTool
{
    [JsonAsset("MoverStandaloneLiaisonComponent")]
    public class UMoverStandaloneLiaisonComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}