namespace AssetTool
{
    [JsonAsset("PawnSensingComponent")]
    public class UPawnSensingComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}