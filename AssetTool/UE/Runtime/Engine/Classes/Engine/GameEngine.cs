namespace AssetTool
{
    [JsonAsset("GameEngine")]
    public class UGameEngine : UEngine
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}