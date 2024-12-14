namespace AssetTool
{
    [JsonAsset("InterchangeResult")]
    public class UInterchangeResult : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeResultSuccess")]
    public class UInterchangeResultSuccess : UInterchangeResult
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeResultWarning")]
    public class UInterchangeResultWarning : UInterchangeResult
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeResultError")]
    public class UInterchangeResultError : UInterchangeResult
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeResultWarning_Generic")]
    public class UInterchangeResultWarning_Generic : UInterchangeResultWarning
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeResultError_Generic")]
    public class UInterchangeResultError_Generic : UInterchangeResultError
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeResultError_ReimportFail")]
    public class UInterchangeResultError_ReimportFail : UInterchangeResultError
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeResultDisplay_Generic")]
    public class UInterchangeResultDisplay_Generic : UInterchangeResultSuccess
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}