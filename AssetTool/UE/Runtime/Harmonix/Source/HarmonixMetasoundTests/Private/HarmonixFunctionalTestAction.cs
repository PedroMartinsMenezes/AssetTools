namespace AssetTool
{
    [JsonAsset("HarmonixFunctionalTestAction")]
    public class UHarmonixFunctionalTestAction : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarmonixFunctionalTestActionSequence")]
    public class UHarmonixFunctionalTestActionSequence : UHarmonixFunctionalTestAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarmonixFunctionalTestActionParallel")]
    public class UHarmonixFunctionalTestActionParallel : UHarmonixFunctionalTestAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarmonixFunctionalTestActionDelay")]
    public class UHarmonixFunctionalTestActionDelay : UHarmonixFunctionalTestAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarmonixFunctionalTestActionWaitForTimeout")]
    public class UHarmonixFunctionalTestActionWaitForTimeout : UHarmonixFunctionalTestAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarmonixFunctionalTestActionFinishTest")]
    public class UHarmonixFunctionalTestActionFinishTest : UHarmonixFunctionalTestAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}