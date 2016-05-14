namespace DAL.Managers
{
    public class DataManager
    {
        private static DataManager _instance;

        private DataManager() { }

        public static DataManager Instance
        {
            get
            {
                return _instance ?? (_instance = new DataManager());
            }
        }

        private AgentsManager _agentManager;

        public AgentsManager Agents
        {
            get
            {
                if (_agentManager == null)
                    _agentManager = new AgentsManager();
                return _agentManager;
            }
        }

        private ApplicantsManager _ApplicantManager;

        public ApplicantsManager Applicants
        {
            get
            {
                if (_ApplicantManager == null)
                    _ApplicantManager = new ApplicantsManager();
                return _ApplicantManager;
            }
        }

        private VehiclesManager _vehicleManager;

        public VehiclesManager Vehicles
        {
            get
            {
                if (_vehicleManager == null)
                    _vehicleManager = new VehiclesManager();
                return _vehicleManager;
            }
        }

        private PoliciesManager _policyManager;

        public PoliciesManager Policys
        {
            get
            {
                if (_policyManager == null)
                    _policyManager = new PoliciesManager();
                return _policyManager;
            }
        }

        private QuotesManager _quoteManager;

        public QuotesManager Quotes
        {
            get
            {
                if (_quoteManager == null)
                    _quoteManager = new QuotesManager();
                return _quoteManager;
            }
        }

        private DriversManager _driverManager;

        public DriversManager Drivers
        {
            get
            {
                if (_driverManager == null)
                    _driverManager = new DriversManager();
                return _driverManager;
            }
        }

        private IncidentManager _incidentManager;

        public IncidentManager Incidents
        {
            get
            {
                if (_incidentManager == null)
                    _incidentManager = new IncidentManager();
                return _incidentManager;
            }
        }
        #region Extra params


        //private SMSManager _smsManager;

        //public SMSManager SMSmessages
        //{
        //    get
        //    {
        //        if (_smsManager == null)
        //            _smsManager = new SMSManager();
        //        return _smsManager;
        //    }
        //}

        //private EmailsManager _emailManager;

        //public EmailsManager EmailMessages
        //{
        //    get
        //    {
        //        if (_emailManager == null)
        //            _emailManager = new EmailsManager();
        //        return _emailManager;
        //    }
        //}

        //private TriagesManager _triagesManager;

        //public TriagesManager Triages
        //{
        //    get
        //    {
        //        if (_triagesManager == null)
        //            _triagesManager = new TriagesManager();
        //        return _triagesManager;
        //    }
        //}

        //private TriageFollowUpManager _triagesFollowUpManager;

        //public TriageFollowUpManager TriageFollowUps
        //{
        //    get
        //    {
        //        if (_triagesFollowUpManager == null)
        //            _triagesFollowUpManager = new TriageFollowUpManager();
        //        return _triagesFollowUpManager;
        //    }
        //}


        //private AutoResponderManager _autoResponderManager;

        //public AutoResponderManager AutoResponder
        //{
        //    get
        //    {
        //        if (_autoResponderManager == null)
        //            _autoResponderManager = new AutoResponderManager();
        //        return _autoResponderManager;
        //    }
        //}

        //private ManyToManyRelationshipManager _manyToManyRelationshipManager;

        //public ManyToManyRelationshipManager ManyToManyRelationShips
        //{
        //    get
        //    {
        //        if (_manyToManyRelationshipManager == null)
        //            _manyToManyRelationshipManager = new ManyToManyRelationshipManager();
        //        return _manyToManyRelationshipManager;
        //    }
        //}

        //private TemplateManager _templateManager;

        //public TemplateManager Templates
        //{
        //    get
        //    {
        //        if (_templateManager == null)
        //            _templateManager = new TemplateManager();
        //        return _templateManager;
        //    }
        //}


        //private VoiceManager _voiceManager;

        //public VoiceManager VoiceCalls
        //{
        //    get
        //    {
        //        if (_voiceManager == null)
        //            _voiceManager = new VoiceManager();
        //        return _voiceManager;
        //    }
        //}

        #endregion
    }
}
