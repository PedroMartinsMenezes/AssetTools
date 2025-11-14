namespace AssetTool
{
    [JsonAsset("GameEngine")]
    public class UGameEngine : UEngine
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}