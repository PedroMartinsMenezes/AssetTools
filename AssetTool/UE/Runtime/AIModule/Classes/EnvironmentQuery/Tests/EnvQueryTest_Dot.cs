namespace AssetTool
{
    [JsonAsset("EnvQueryTest_Dot")]
    public class UEnvQueryTest_Dot : UEnvQueryTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}