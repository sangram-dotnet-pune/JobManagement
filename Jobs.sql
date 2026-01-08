CREATE TABLE jobs (
    id BIGINT IDENTITY(1,1) PRIMARY KEY,
    
    title NVARCHAR(150) NOT NULL,
    description NVARCHAR(MAX) NOT NULL,
    
    location NVARCHAR(100),
    employment_type NVARCHAR(50),  
    experience_level NVARCHAR(50), 
    
    salary_min DECIMAL(10,2),
    salary_max DECIMAL(10,2),
    
    status NVARCHAR(30) NOT NULL DEFAULT 'OPEN', 
    
    created_by BIGINT NULL, 
    
    created_at DATETIME2 DEFAULT GETDATE(),
    updated_at DATETIME2
);