CREATE TABLE applications (
    id BIGINT IDENTITY(1,1) PRIMARY KEY,
    
    job_id BIGINT NOT NULL,
    applicant_id BIGINT NOT NULL, 
    
    resume_snapshot_url NVARCHAR(255),
    cover_letter NVARCHAR(MAX),
    
    status NVARCHAR(30) NOT NULL DEFAULT 'APPLIED',
    
    applied_at DATETIME2 DEFAULT GETDATE(),
    updated_at DATETIME2,
    
    CONSTRAINT uq_job_applicant UNIQUE (job_id, applicant_id)
);