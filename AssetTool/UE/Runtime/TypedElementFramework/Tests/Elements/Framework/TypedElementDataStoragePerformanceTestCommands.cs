namespace AssetTool
{
    [JsonAsset("Test_PingPongBetweenPhaseFactory")]
    public class UTest_PingPongBetweenPhaseFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}