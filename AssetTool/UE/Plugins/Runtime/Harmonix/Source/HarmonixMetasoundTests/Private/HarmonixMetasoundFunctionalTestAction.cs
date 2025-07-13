namespace AssetTool
{
    [JsonAsset("HarmonixMetasoundFunctionalTestActionSetAudioParameter")]
    public class UHarmonixMetasoundFunctionalTestActionSetAudioParameter : UHarmonixFunctionalTestAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarmonixMetasoundFunctionalTestActionSetWaitForAudioFinished")]
    public class UHarmonixMetasoundFunctionalTestActionSetWaitForAudioFinished : UHarmonixFunctionalTestAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}