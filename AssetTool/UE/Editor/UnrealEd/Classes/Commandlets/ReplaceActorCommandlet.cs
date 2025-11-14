namespace AssetTool
{
    [JsonAsset("ReplaceActorCommandlet")]
    public class UReplaceActorCommandlet : UCommandlet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}