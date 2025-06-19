namespace AssetTool
{
    [JsonAsset("AISenseEvent_Damage")]
    public class UAISenseEvent_Damage : UAISenseEvent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}