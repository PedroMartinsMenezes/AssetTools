namespace AssetTool
{
    [JsonAsset("GameEngine")]
    public class UGameEngine : UEngine
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}