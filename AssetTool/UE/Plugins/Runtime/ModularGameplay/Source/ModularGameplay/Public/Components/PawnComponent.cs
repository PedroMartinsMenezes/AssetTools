namespace AssetTool
{
    [JsonAsset("PawnComponent")]
    public class UPawnComponent : UGameFrameworkComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}