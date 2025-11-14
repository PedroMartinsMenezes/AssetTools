namespace AssetTool
{
    [JsonAsset("PawnSensingComponent")]
    public class UPawnSensingComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}