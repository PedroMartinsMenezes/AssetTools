namespace AssetTool
{
    [JsonAsset("MoverStandaloneLiaisonComponent")]
    public class UMoverStandaloneLiaisonComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}