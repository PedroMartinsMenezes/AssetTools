namespace AssetTool
{
    [JsonAsset("ReplaceActorCommandlet")]
    public class UReplaceActorCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}