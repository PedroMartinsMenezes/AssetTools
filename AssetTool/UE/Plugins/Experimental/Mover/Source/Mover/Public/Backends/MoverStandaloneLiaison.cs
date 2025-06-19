namespace AssetTool
{
    [JsonAsset("MoverStandaloneLiaisonComponent")]
    public class UMoverStandaloneLiaisonComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}