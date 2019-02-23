namespace Domain.Entities
{
    public class Candidate
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string ReferenceNumber { get; set; }
        public long ContactInfoId { get; set; }
        public long GeneralInfoId { get; set; }
        public CandidateStage CandidateStage { get; set; }
    }

    public class NewCandidate
    {
        public long UserId { get; set; }
        public string ReferenceNumber { get; set; }
        public long ContactInfoId { get; set; }
        public long GeneralInfoId { get; set; }
        public CandidateStage CandidateStage = 0;
    }
    
    public enum CandidateStage
    {
        Registered = 0,
        Paid = 1,
        AwaitingCourse = 2,
        CourseJoiningInstructions = 3,
        GroundSchoolSyllabus = 4,
        GroundSchoolExam = 5,
        ApproveExamResults = 6,
        ReturnExamResults = 7,
        GivenOpsManualTemplate = 8,
        ReturnedOpsManual = 9,
        InsuranceCheck = 10,
        FlightAssessment = 11,
        CaaPfCoRecommendation = 12,
        CourseReview = 13
    }
}