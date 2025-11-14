namespace AssetTool
{
    [JsonAsset("LyraCameraComponent")]
    public class ULyraCameraComponent : UCameraComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}